using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UpdateCreationUI
{
    partial class Form1
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.container_installerDetails = new System.Windows.Forms.Panel();
            this.container_projectDetails = new System.Windows.Forms.Panel();
            this.container_fileDetails = new System.Windows.Forms.Panel();
            this.upgrdCode_Label_Insert = new System.Windows.Forms.Label();
            this.manu_Label_Insert = new System.Windows.Forms.Label();
            this.GUID_Label_Insert = new System.Windows.Forms.Label();
            this.prodName_Label_Insert = new System.Windows.Forms.Label();
            this.bakGrpTwo_Btn = new System.Windows.Forms.Button();
            this.buildVerPreFil_Label = new System.Windows.Forms.Label();
            this.minVerPreFil_Label = new System.Windows.Forms.Label();
            this.dot3 = new System.Windows.Forms.Label();
            this.newBuild_txtBox = new System.Windows.Forms.TextBox();
            this.dot2_Label = new System.Windows.Forms.Label();
            this.maVer_Label = new System.Windows.Forms.Label();
            this.prevVer_Label_Insert = new System.Windows.Forms.Label();
            this.newMin_TxtBox = new System.Windows.Forms.TextBox();
            this.newVer_Label = new System.Windows.Forms.Label();
            this.upgradeCode_Label = new System.Windows.Forms.Label();
            this.manufact_Label = new System.Windows.Forms.Label();
            this.prodName_Label = new System.Windows.Forms.Label();
            this.GUID_Label = new System.Windows.Forms.Label();
            this.prevVer_Label = new System.Windows.Forms.Label();
            this.grpTwoNext_btn = new System.Windows.Forms.Button();
            this.projectDetailsIntoLabel = new System.Windows.Forms.Label();
            this.grpOneNext_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.installerType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.patchControls = new System.Windows.Forms.Panel();
            this.browse = new System.Windows.Forms.Button();
            this.prevXMLPath = new System.Windows.Forms.Label();
            this.upgrdType = new System.Windows.Forms.ComboBox();
            this.upgrdTypeLabel = new System.Windows.Forms.Label();
            this.grpThreeNext_btn = new System.Windows.Forms.Button();
            this.back2_btn = new System.Windows.Forms.Button();
            this.fileDetails_label = new System.Windows.Forms.Label();
            this.fileFound_Label = new System.Windows.Forms.Label();
            this.container_installerDetails.SuspendLayout();
            this.container_projectDetails.SuspendLayout();
            this.container_fileDetails.SuspendLayout();
            this.patchControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // container_installerDetails
            // 
            this.container_installerDetails.Controls.Add(this.container_projectDetails);
            this.container_installerDetails.Controls.Add(this.grpOneNext_btn);
            this.container_installerDetails.Controls.Add(this.label2);
            this.container_installerDetails.Controls.Add(this.installerType);
            this.container_installerDetails.Controls.Add(this.label1);
            this.container_installerDetails.Controls.Add(this.patchControls);
            this.container_installerDetails.Location = new System.Drawing.Point(12, 12);
            this.container_installerDetails.Name = "container_installerDetails";
            this.container_installerDetails.Size = new System.Drawing.Size(571, 387);
            this.container_installerDetails.TabIndex = 0;
            // 
            // container_projectDetails
            // 
            this.container_projectDetails.Controls.Add(this.upgrdCode_Label_Insert);
            this.container_projectDetails.Controls.Add(this.manu_Label_Insert);
            this.container_projectDetails.Controls.Add(this.GUID_Label_Insert);
            this.container_projectDetails.Controls.Add(this.prodName_Label_Insert);
            this.container_projectDetails.Controls.Add(this.bakGrpTwo_Btn);
            this.container_projectDetails.Controls.Add(this.buildVerPreFil_Label);
            this.container_projectDetails.Controls.Add(this.minVerPreFil_Label);
            this.container_projectDetails.Controls.Add(this.dot3);
            this.container_projectDetails.Controls.Add(this.newBuild_txtBox);
            this.container_projectDetails.Controls.Add(this.dot2_Label);
            this.container_projectDetails.Controls.Add(this.maVer_Label);
            this.container_projectDetails.Controls.Add(this.prevVer_Label_Insert);
            this.container_projectDetails.Controls.Add(this.newMin_TxtBox);
            this.container_projectDetails.Controls.Add(this.newVer_Label);
            this.container_projectDetails.Controls.Add(this.upgradeCode_Label);
            this.container_projectDetails.Controls.Add(this.manufact_Label);
            this.container_projectDetails.Controls.Add(this.prodName_Label);
            this.container_projectDetails.Controls.Add(this.GUID_Label);
            this.container_projectDetails.Controls.Add(this.prevVer_Label);
            this.container_projectDetails.Controls.Add(this.grpTwoNext_btn);
            this.container_projectDetails.Controls.Add(this.projectDetailsIntoLabel);
            this.container_projectDetails.Location = new System.Drawing.Point(0, 0);
            this.container_projectDetails.Name = "container_projectDetails";
            this.container_projectDetails.Size = new System.Drawing.Size(571, 387);
            this.container_projectDetails.TabIndex = 14;
            this.container_projectDetails.Visible = false;
            this.container_projectDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.projectDetails_Paint);
            // 
            // container_fileDetails
            // 
            this.container_fileDetails.Controls.Add(this.fileFound_Label);
            this.container_fileDetails.Controls.Add(this.fileDetails_label);
            this.container_fileDetails.Controls.Add(this.back2_btn);
            this.container_fileDetails.Controls.Add(this.grpThreeNext_btn);
            this.container_fileDetails.Location = new System.Drawing.Point(12, 12);
            this.container_fileDetails.Name = "container_fileDetails";
            this.container_fileDetails.Size = new System.Drawing.Size(579, 387);
            this.container_fileDetails.TabIndex = 22;
            this.container_fileDetails.Visible = false;
            // 
            // upgrdCode_Label_Insert
            // 
            this.upgrdCode_Label_Insert.AutoSize = true;
            this.upgrdCode_Label_Insert.Location = new System.Drawing.Point(208, 166);
            this.upgrdCode_Label_Insert.Name = "upgrdCode_Label_Insert";
            this.upgrdCode_Label_Insert.Size = new System.Drawing.Size(88, 17);
            this.upgrdCode_Label_Insert.TabIndex = 21;
            this.upgrdCode_Label_Insert.Text = "{upgrdCode}";
            // 
            // manu_Label_Insert
            // 
            this.manu_Label_Insert.AutoSize = true;
            this.manu_Label_Insert.Location = new System.Drawing.Point(415, 74);
            this.manu_Label_Insert.Name = "manu_Label_Insert";
            this.manu_Label_Insert.Size = new System.Drawing.Size(90, 17);
            this.manu_Label_Insert.TabIndex = 20;
            this.manu_Label_Insert.Text = "{manuName}";
            // 
            // GUID_Label_Insert
            // 
            this.GUID_Label_Insert.AutoSize = true;
            this.GUID_Label_Insert.Location = new System.Drawing.Point(152, 119);
            this.GUID_Label_Insert.Name = "GUID_Label_Insert";
            this.GUID_Label_Insert.Size = new System.Drawing.Size(52, 17);
            this.GUID_Label_Insert.TabIndex = 19;
            this.GUID_Label_Insert.Text = "{GUID}";
            // 
            // prodName_Label_Insert
            // 
            this.prodName_Label_Insert.AutoSize = true;
            this.prodName_Label_Insert.Location = new System.Drawing.Point(208, 74);
            this.prodName_Label_Insert.Name = "prodName_Label_Insert";
            this.prodName_Label_Insert.Size = new System.Drawing.Size(84, 17);
            this.prodName_Label_Insert.TabIndex = 18;
            this.prodName_Label_Insert.Text = "{prodName}";
            // 
            // bakGrpTwo_Btn
            // 
            this.bakGrpTwo_Btn.Location = new System.Drawing.Point(28, 346);
            this.bakGrpTwo_Btn.Name = "bakGrpTwo_Btn";
            this.bakGrpTwo_Btn.Size = new System.Drawing.Size(75, 23);
            this.bakGrpTwo_Btn.TabIndex = 17;
            this.bakGrpTwo_Btn.Text = "Back";
            this.bakGrpTwo_Btn.UseVisualStyleBackColor = true;
            this.bakGrpTwo_Btn.Click += new System.EventHandler(this.goBack_Click);
            // 
            // buildVerPreFil_Label
            // 
            this.buildVerPreFil_Label.AutoSize = true;
            this.buildVerPreFil_Label.Location = new System.Drawing.Point(492, 222);
            this.buildVerPreFil_Label.Name = "buildVerPreFil_Label";
            this.buildVerPreFil_Label.Size = new System.Drawing.Size(16, 17);
            this.buildVerPreFil_Label.TabIndex = 16;
            this.buildVerPreFil_Label.Text = "0";
            this.buildVerPreFil_Label.Visible = false;
            // 
            // minVerPreFil_Label
            // 
            this.minVerPreFil_Label.AutoSize = true;
            this.minVerPreFil_Label.Location = new System.Drawing.Point(438, 222);
            this.minVerPreFil_Label.Name = "minVerPreFil_Label";
            this.minVerPreFil_Label.Size = new System.Drawing.Size(16, 17);
            this.minVerPreFil_Label.TabIndex = 15;
            this.minVerPreFil_Label.Text = "0";
            this.minVerPreFil_Label.Visible = false;
            // 
            // dot3
            // 
            this.dot3.AutoSize = true;
            this.dot3.Location = new System.Drawing.Point(474, 222);
            this.dot3.Name = "dot3";
            this.dot3.Size = new System.Drawing.Size(12, 17);
            this.dot3.TabIndex = 14;
            this.dot3.Text = ".";
            this.dot3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // newBuild_txtBox
            // 
            this.newBuild_txtBox.Location = new System.Drawing.Point(492, 219);
            this.newBuild_txtBox.Name = "newBuild_txtBox";
            this.newBuild_txtBox.Size = new System.Drawing.Size(26, 22);
            this.newBuild_txtBox.TabIndex = 13;
            this.newBuild_txtBox.Visible = false;
            // 
            // dot2_Label
            // 
            this.dot2_Label.AutoSize = true;
            this.dot2_Label.Location = new System.Drawing.Point(420, 222);
            this.dot2_Label.Name = "dot2_Label";
            this.dot2_Label.Size = new System.Drawing.Size(12, 17);
            this.dot2_Label.TabIndex = 12;
            this.dot2_Label.Text = ".";
            // 
            // maVer_Label
            // 
            this.maVer_Label.AutoSize = true;
            this.maVer_Label.Location = new System.Drawing.Point(407, 222);
            this.maVer_Label.Name = "maVer_Label";
            this.maVer_Label.Size = new System.Drawing.Size(16, 17);
            this.maVer_Label.TabIndex = 11;
            this.maVer_Label.Text = "1";
            // 
            // prevVer_Label_Insert
            // 
            this.prevVer_Label_Insert.AutoSize = true;
            this.prevVer_Label_Insert.Location = new System.Drawing.Point(219, 222);
            this.prevVer_Label_Insert.Name = "prevVer_Label_Insert";
            this.prevVer_Label_Insert.Size = new System.Drawing.Size(73, 17);
            this.prevVer_Label_Insert.TabIndex = 10;
            this.prevVer_Label_Insert.Text = "{Prev Ver}";
            // 
            // newMin_TxtBox
            // 
            this.newMin_TxtBox.Location = new System.Drawing.Point(438, 218);
            this.newMin_TxtBox.Name = "newMin_TxtBox";
            this.newMin_TxtBox.Size = new System.Drawing.Size(26, 22);
            this.newMin_TxtBox.TabIndex = 9;
            this.newMin_TxtBox.Visible = false;
            this.newMin_TxtBox.TextChanged += new System.EventHandler(this.newVerInptTest);
            // 
            // newVer_Label
            // 
            this.newVer_Label.AutoSize = true;
            this.newVer_Label.Location = new System.Drawing.Point(313, 222);
            this.newVer_Label.Name = "newVer_Label";
            this.newVer_Label.Size = new System.Drawing.Size(91, 17);
            this.newVer_Label.TabIndex = 8;
            this.newVer_Label.Text = "New Version:";
            // 
            // upgradeCode_Label
            // 
            this.upgradeCode_Label.AutoSize = true;
            this.upgradeCode_Label.Location = new System.Drawing.Point(100, 166);
            this.upgradeCode_Label.Name = "upgradeCode_Label";
            this.upgradeCode_Label.Size = new System.Drawing.Size(104, 17);
            this.upgradeCode_Label.TabIndex = 7;
            this.upgradeCode_Label.Text = "Upgrade Code:";
            // 
            // manufact_Label
            // 
            this.manufact_Label.AutoSize = true;
            this.manufact_Label.Location = new System.Drawing.Point(313, 74);
            this.manufact_Label.Name = "manufact_Label";
            this.manufact_Label.Size = new System.Drawing.Size(96, 17);
            this.manufact_Label.TabIndex = 6;
            this.manufact_Label.Text = "Manufacturer:";
            // 
            // prodName_Label
            // 
            this.prodName_Label.AutoSize = true;
            this.prodName_Label.Location = new System.Drawing.Point(100, 74);
            this.prodName_Label.Name = "prodName_Label";
            this.prodName_Label.Size = new System.Drawing.Size(102, 17);
            this.prodName_Label.TabIndex = 5;
            this.prodName_Label.Text = "Product Name:";
            // 
            // GUID_Label
            // 
            this.GUID_Label.AutoSize = true;
            this.GUID_Label.Location = new System.Drawing.Point(100, 119);
            this.GUID_Label.Name = "GUID_Label";
            this.GUID_Label.Size = new System.Drawing.Size(46, 17);
            this.GUID_Label.TabIndex = 4;
            this.GUID_Label.Text = "GUID:";
            // 
            // prevVer_Label
            // 
            this.prevVer_Label.AutoSize = true;
            this.prevVer_Label.Location = new System.Drawing.Point(100, 222);
            this.prevVer_Label.Name = "prevVer_Label";
            this.prevVer_Label.Size = new System.Drawing.Size(119, 17);
            this.prevVer_Label.TabIndex = 3;
            this.prevVer_Label.Text = "Previous Version:";
            // 
            // grpTwoNext_btn
            // 
            this.grpTwoNext_btn.Enabled = false;
            this.grpTwoNext_btn.Location = new System.Drawing.Point(459, 346);
            this.grpTwoNext_btn.Name = "grpTwoNext_btn";
            this.grpTwoNext_btn.Size = new System.Drawing.Size(75, 23);
            this.grpTwoNext_btn.TabIndex = 1;
            this.grpTwoNext_btn.Text = "Next";
            this.grpTwoNext_btn.UseVisualStyleBackColor = true;
            this.grpTwoNext_btn.Click += new System.EventHandler(this.grpTwoNext_Click);
            // 
            // projectDetailsIntoLabel
            // 
            this.projectDetailsIntoLabel.AutoSize = true;
            this.projectDetailsIntoLabel.Location = new System.Drawing.Point(233, 27);
            this.projectDetailsIntoLabel.Name = "projectDetailsIntoLabel";
            this.projectDetailsIntoLabel.Size = new System.Drawing.Size(99, 17);
            this.projectDetailsIntoLabel.TabIndex = 0;
            this.projectDetailsIntoLabel.Text = "Project Details";
            // 
            // grpOneNext_btn
            // 
            this.grpOneNext_btn.Enabled = false;
            this.grpOneNext_btn.Location = new System.Drawing.Point(459, 346);
            this.grpOneNext_btn.Name = "grpOneNext_btn";
            this.grpOneNext_btn.Size = new System.Drawing.Size(75, 23);
            this.grpOneNext_btn.TabIndex = 12;
            this.grpOneNext_btn.Text = " Next";
            this.grpOneNext_btn.UseVisualStyleBackColor = true;
            this.grpOneNext_btn.Click += new System.EventHandler(this.grpOneNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Type of installer:";
            // 
            // installerType
            // 
            this.installerType.FormattingEnabled = true;
            this.installerType.Items.AddRange(new object[] {
            "Patch",
            "Major Upgrade/New"});
            this.installerType.Location = new System.Drawing.Point(314, 119);
            this.installerType.Name = "installerType";
            this.installerType.Size = new System.Drawing.Size(157, 24);
            this.installerType.TabIndex = 10;
            this.installerType.SelectedIndexChanged += new System.EventHandler(this.installer_Select);
            this.installerType.SelectionChangeCommitted += new System.EventHandler(this.installer_Select);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome to the Installer Creation Tool";
            // 
            // patchControls
            // 
            this.patchControls.Controls.Add(this.browse);
            this.patchControls.Controls.Add(this.prevXMLPath);
            this.patchControls.Controls.Add(this.upgrdType);
            this.patchControls.Controls.Add(this.upgrdTypeLabel);
            this.patchControls.Location = new System.Drawing.Point(110, 166);
            this.patchControls.Name = "patchControls";
            this.patchControls.Size = new System.Drawing.Size(361, 124);
            this.patchControls.TabIndex = 13;
            this.patchControls.Visible = false;
            // 
            // browse
            // 
            this.browse.Enabled = false;
            this.browse.Location = new System.Drawing.Point(283, 73);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 11;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // prevXMLPath
            // 
            this.prevXMLPath.AutoSize = true;
            this.prevXMLPath.Location = new System.Drawing.Point(-2, 73);
            this.prevXMLPath.Name = "prevXMLPath";
            this.prevXMLPath.Size = new System.Drawing.Size(157, 17);
            this.prevXMLPath.TabIndex = 10;
            this.prevXMLPath.Text = "Previous Wix XML path:";
            // 
            // upgrdType
            // 
            this.upgrdType.FormattingEnabled = true;
            this.upgrdType.Items.AddRange(new object[] {
            "Minor",
            "Build"});
            this.upgrdType.Location = new System.Drawing.Point(204, 5);
            this.upgrdType.Name = "upgrdType";
            this.upgrdType.Size = new System.Drawing.Size(154, 24);
            this.upgrdType.TabIndex = 9;
            this.upgrdType.SelectedIndexChanged += new System.EventHandler(this.upgrdType_Select);
            // 
            // upgrdTypeLabel
            // 
            this.upgrdTypeLabel.AutoSize = true;
            this.upgrdTypeLabel.Location = new System.Drawing.Point(-2, 8);
            this.upgrdTypeLabel.Name = "upgrdTypeLabel";
            this.upgrdTypeLabel.Size = new System.Drawing.Size(94, 17);
            this.upgrdTypeLabel.TabIndex = 8;
            this.upgrdTypeLabel.Text = "Upgrade type";
            // 
            // grpThreeNext_btn
            // 
            this.grpThreeNext_btn.Location = new System.Drawing.Point(459, 346);
            this.grpThreeNext_btn.Name = "grpThreeNext_btn";
            this.grpThreeNext_btn.Size = new System.Drawing.Size(75, 23);
            this.grpThreeNext_btn.TabIndex = 0;
            this.grpThreeNext_btn.Text = "Next";
            this.grpThreeNext_btn.UseVisualStyleBackColor = true;
            // 
            // back2_btn
            // 
            this.back2_btn.Location = new System.Drawing.Point(28, 346);
            this.back2_btn.Name = "back2_btn";
            this.back2_btn.Size = new System.Drawing.Size(75, 23);
            this.back2_btn.TabIndex = 1;
            this.back2_btn.Text = "Back";
            this.back2_btn.UseVisualStyleBackColor = true;
            this.back2_btn.Click += new System.EventHandler(this.goBack_Click);
            // 
            // fileDetails_label
            // 
            this.fileDetails_label.AutoSize = true;
            this.fileDetails_label.Location = new System.Drawing.Point(255, 27);
            this.fileDetails_label.Name = "fileDetails_label";
            this.fileDetails_label.Size = new System.Drawing.Size(77, 17);
            this.fileDetails_label.TabIndex = 2;
            this.fileDetails_label.Text = "File Details";
            // 
            // fileFound_Label
            // 
            this.fileFound_Label.AutoSize = true;
            this.fileFound_Label.Location = new System.Drawing.Point(68, 74);
            this.fileFound_Label.Name = "fileFound_Label";
            this.fileFound_Label.Size = new System.Drawing.Size(78, 17);
            this.fileFound_Label.TabIndex = 3;
            this.fileFound_Label.Text = "File Found:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 411);
            this.Controls.Add(this.container_fileDetails);
            this.Controls.Add(this.container_installerDetails);
            this.Name = "Form1";
            this.Text = "Installer Creation Tool";
            this.container_installerDetails.ResumeLayout(false);
            this.container_installerDetails.PerformLayout();
            this.container_projectDetails.ResumeLayout(false);
            this.container_projectDetails.PerformLayout();
            this.container_fileDetails.ResumeLayout(false);
            this.container_fileDetails.PerformLayout();
            this.patchControls.ResumeLayout(false);
            this.patchControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel container_installerDetails;
        private Button grpOneNext_btn;
        private Label label2;
        private ComboBox installerType;
        private Label label1;
        private Panel patchControls;
        private Button browse;
        private Label prevXMLPath;
        private ComboBox upgrdType;
        private Label upgrdTypeLabel;
        private Panel container_projectDetails;
        private Button grpTwoNext_btn;
        private Label projectDetailsIntoLabel;
        private TextBox newMin_TxtBox;
        private Label newVer_Label;
        private Label upgradeCode_Label;
        private Label manufact_Label;
        private Label prodName_Label;
        private Label GUID_Label;
        private Label prevVer_Label;
        private Label prevVer_Label_Insert;
        private Label maVer_Label;
        private TextBox newBuild_txtBox;
        private Label dot2_Label;
        private Label dot3;
        private Label buildVerPreFil_Label;
        private Label minVerPreFil_Label;
        private Button bakGrpTwo_Btn;
        private Label upgrdCode_Label_Insert;
        private Label manu_Label_Insert;
        private Label GUID_Label_Insert;
        private Label prodName_Label_Insert;
        private Panel container_fileDetails;
        private Button grpThreeNext_btn;
        private Button back2_btn;
        private Label fileFound_Label;
        private Label fileDetails_label;


    }
}

