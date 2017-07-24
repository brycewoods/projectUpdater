using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace UpdateCreationUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grpOneNext_Click(object sender, System.EventArgs e)
        {
            
            // Read wix file
            // Get version number and project details
            if(readWixFile(wixFilePath))
            {
                // If back button has been used.
                // Clear all update fields
                if(grpTwoComplete)
                {
                    // Reset Fields
                    prodName_Label_Insert.Text = null;
                    manu_Label_Insert.Text = null;
                    GUID_Label_Insert.Text = null;
                    upgrdCode_Label_Insert.Text = null;
                    prevVer_Label_Insert.Text = null;

                    // Reset Version Fields
                    newBuild_txtBox.Visible = false;
                    minVerPreFil_Label.Visible = false;
                    newMin_TxtBox.Visible = false;
                    buildVerPreFil_Label.Visible = false;
                }

                // Fill in all the details for patching
                prodName_Label_Insert.Text = prodDets[0];
                manu_Label_Insert.Text = prodDets[1];
                GUID_Label_Insert.Text = prodDets[2];
                upgrdCode_Label_Insert.Text = prodDets[3];
                prevVer_Label_Insert.Text = prodDets[4];

                if(upgrdType.SelectedItem.ToString() == "Build")
                {
                    newBuild_txtBox.Visible = true;
                    minVerPreFil_Label.Visible = true;
                }
                else
                {
                    newMin_TxtBox.Visible = true;
                    buildVerPreFil_Label.Visible = true;
                }

                // Raise completion flag
                if(!grpTwoComplete)
                {
                    grpTwoComplete = true;
                }
             
                container_projectDetails.Visible = true;

            }
            else
            {
                MessageBox.Show("Error: XML missing: " + lastError);

                // Hide Next button
                grpOneNext_btn.Enabled = false;
            }
        }

        // Shows different dialog options depending on selected item
        // If selected item is patch, show patch related options
        private void installer_Select(object sender, System.EventArgs e)
        {
            if(installerType.SelectedIndex == 0)
            {
                patchControls.Visible = true;

                // Need to fill out rest of information
                if(grpOneNext_btn.Enabled)
                {
                    grpOneNext_btn.Enabled = false;
                }
            }
            else
            {
                patchControls.Visible = false;

                grpOneNext_btn.Enabled = true;
            }

            
        }

        private void browse_Click(object sender, System.EventArgs e)
        {
            wixFilePath = getFilePath("Wix XML (*.wxs) |*.wxs");
        }

        private void upgrdType_Select(object sender, System.EventArgs e)
        {
            browse.Enabled = true;
        }

        private string getFilePath(string filter)
        {
            // File Dialog object finds files
            OpenFileDialog wixFinder = new OpenFileDialog();
            string wixFilePath = "";

            wixFinder.Filter = filter;

            // Gets result of finding file
            System.Windows.Forms.DialogResult result = wixFinder.ShowDialog();
            

            if(result == DialogResult.OK)
            {
                wixFilePath = wixFinder.FileName.ToString();

                // Enable next click.
                grpOneNext_btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error Accessing File!");

                if(grpOneNext_btn.Enabled)
                {
                    grpOneNext_btn.Enabled = false;
                }

            }

            return wixFilePath;

        }

      
      
        // Reads wix file and gets basic project details.
        // Returns if all details were found.
        private bool readWixFile(string wixFile)
        {
            bool complete = true;
            string[] wixFileDetails = { };

            using(System.IO.StreamReader reader = new System.IO.StreamReader(wixFile))
            {
                // Helper variables.
                string line = "";
                int i = 0;
                string[] tmp;
                FileInfo foundFile;

                while((line = reader.ReadLine()) != null)
                {
                    // Split the line.
                    tmp = line.Split('"');


                    // Search for file details.
                    for(i = 0; i < prodDetsRead.Length; i++)
                    {
                        if(line.Contains(prodDetsRead[i]))
                        {
                            
                            prodDets[i] = tmp[1];

                            break;
                        }
                    }

                    // Search for file information.
                    if(line.Contains("File"))
                    {
                        // Grab source line.
                        for(i = 0; i < tmp.Length; i++)
                        {
                            if(tmp[i].Contains("Source"))
                            {
                                // Next index will be source path as split is done per ".
                                Console.WriteLine(tmp[i + 1]);

                                foundFile = new FileInfo(tmp[i + 1]);

                                
                                // Add file infos to list
                                prevInstFiles.Add(foundFile);


                            }
                        }
                    }
                    

                }
                    
            }


            // Check to see if all values where found.
            for (int i = 0; i < prodDets.Length; i++ )
            {

                if (prodDets[i] == null)
                {
                    lastError = prodDetsRead[i];
                    complete = false;
                    break;
                }
            }


            return complete;
        }

        private void newVerInptTest(object sender, EventArgs e)
        {
            int verUpgrade;

            string[] prevVer = prevVer_Label_Insert.Text.Split('.');

            if(upgrdType.SelectedItem.ToString() == "Minor")
            {
                string miVer = newMin_TxtBox.Text;
                if (miVer != "")
                {
                    if (!Int32.TryParse(miVer, out verUpgrade))
                    {
                        MessageBox.Show("Minor version must be a number.");

                        grpTwoNext_btn.Enabled = false;
                    }
                    else if (Int32.Parse(miVer) <= Int32.Parse(prevVer[1]))
                    {
                        MessageBox.Show("Minor version must be greater then previous.");

                        grpTwoNext_btn.Enabled = false;
                    }
                    else if(Int32.Parse(miVer) > Int32.Parse(prevVer[1]) + 1)
                    {
                        MessageBox.Show("NOTICE: New version increment is greater then previous + 1. Continue if OK.");
                    }
                    else
                    {

                        grpTwoNext_btn.Enabled = true;
                    }
                }
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void projectDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void goBack_Click(object sender, EventArgs e)
        {
            // Get the back button that sent is to be handled.
            Console.WriteLine(sender.GetType());

            // Convert object to form button to get parent
            System.Windows.Forms.Button inpt_btn = (System.Windows.Forms.Button)sender;

            // Hide parent
            inpt_btn.Parent.Hide();
        }

        private void grpTwoNext_Click(object sender, EventArgs e)
        {
            container_fileDetails.Show();

            // Keeps track of label positions
            Int32 yTracker = 30;

            // File Inex tracker
            Int32 fileIndex = 0;
            // Show a list of files
            foreach(FileInfo file in prevInstFiles)
            {

                Label fileInfoLabel = new Label();
                Button fileUpdateBtn = new Button();

                fileInfoLabel.Text = file.Name;

                // Sets the location of the file labels. X doesn't change. Y changes by 30 with each file
                System.Drawing.Point fileLabelLoc = new System.Drawing.Point(fileFound_Label.Location.X + 20, fileFound_Label.Location.Y + yTracker);

                fileInfoLabel.Location = fileLabelLoc;

                // Add the buttons
                // Is position relative to the assosiated label
                // Y stays the same, X moves to give space.
                fileUpdateBtn.Text = "Update";
                // Set name of button, used to pass name of file and index in files found.
                fileUpdateBtn.Name = fileIndex + "_Update_btn";

                // Add click event
                fileUpdateBtn.Click += new EventHandler(this.updateFileSelect_Click);
                
                

                System.Drawing.Point updateBtnLoc = new System.Drawing.Point(fileLabelLoc.X + 300, fileLabelLoc.Y - 4);
                fileUpdateBtn.Location = updateBtnLoc;
                           
                
                // Add controls to container
                container_fileDetails.Controls.Add(fileInfoLabel);
                container_fileDetails.Controls.Add(fileUpdateBtn);
                

                // Keep same position between file labels
                yTracker = yTracker + 30;

                // Increase index
                fileIndex++;

            }

        }

        // File update button handler
        private void updateFileSelect_Click(object sender, EventArgs e)
        {
            

            // Get button information
            Button updateBtn = (Button)sender;

            // Get file index stored in button name
            string[] btnSplit = updateBtn.Name.Split('_');

            int fileIndex = Int32.Parse(btnSplit[0]);

            //Console.WriteLine(prevInstFiles[fileIndex].Name);

            
            // Fail point
            // Set filter to the exact same file. Ensure user doesn't pick wrong file.
            // Create filter.
            string fileFilter = prevInstFiles[fileIndex].Name + "|*" + prevInstFiles[fileIndex].Extension;

            // Show File dialog
            FileInfo updateFile = new FileInfo(getFilePath(fileFilter));


            // Get file details.
            compareFileVer(prevInstFiles[fileIndex], updateFile);



        }

        // Compares two files versions
        // Returns difference between file versions
        private double compareFileVer(FileInfo fileOne, FileInfo fileTwo)
        {
            double difference = 0.0;

            Console.WriteLine(fileOne);


            return difference;
        }

        // Form Information

        // Installer Details
        private string wixFilePath = "";

        // Helper Arrays
        private string[] prodDetsRead = {"<?define NAME","<?define MANUFACTURER","<?define GUID",
                                    "<?define UPGRADECODE","<?define VERSION"};

        // Holds basic project details
        private string[] prodDets = new string[5];

        // Holds Files found
        // Use FileInfo to reduce secruity checks.
        private List<FileInfo> prevInstFiles = new List<FileInfo>();
        private List<FileInfo> updateFiles = new List<FileInfo>();

        // Error Details
        private string lastError = "";

        // Group Complete Variables
        bool grpTwoComplete = false;
    }
    
    
}
