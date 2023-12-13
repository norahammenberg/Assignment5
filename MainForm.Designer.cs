namespace Assignment5
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxNewParty = new GroupBox();
            buttonCreate = new Button();
            textBoxFeePerson = new TextBox();
            textBoxCostPerson = new TextBox();
            textBoxMaxGuest = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBoxInvite = new GroupBox();
            buttonAdd = new Button();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            guestList = new ListBox();
            labelName = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            labelNumGuest = new Label();
            labelTotalCost = new Label();
            labelTotalFee = new Label();
            labelSurplus = new Label();
            buttonDelete = new Button();
            labelAddress = new Label();
            buttonChange = new Button();
            textBoxCity = new TextBox();
            textBoxStreet = new TextBox();
            label7 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBoxPostCode = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            comboBoxCountry = new ComboBox();
            groupBoxEco = new GroupBox();
            groupBoxNewParty.SuspendLayout();
            groupBoxInvite.SuspendLayout();
            groupBoxEco.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxNewParty
            // 
            groupBoxNewParty.Controls.Add(buttonCreate);
            groupBoxNewParty.Controls.Add(textBoxFeePerson);
            groupBoxNewParty.Controls.Add(textBoxCostPerson);
            groupBoxNewParty.Controls.Add(textBoxMaxGuest);
            groupBoxNewParty.Controls.Add(label3);
            groupBoxNewParty.Controls.Add(label2);
            groupBoxNewParty.Controls.Add(label1);
            groupBoxNewParty.Location = new Point(87, 69);
            groupBoxNewParty.Name = "groupBoxNewParty";
            groupBoxNewParty.Size = new Size(306, 177);
            groupBoxNewParty.TabIndex = 0;
            groupBoxNewParty.TabStop = false;
            groupBoxNewParty.Text = "New Party";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(172, 136);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(100, 23);
            buttonCreate.TabIndex = 6;
            buttonCreate.Text = "Create Event";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // textBoxFeePerson
            // 
            textBoxFeePerson.Location = new Point(172, 87);
            textBoxFeePerson.Name = "textBoxFeePerson";
            textBoxFeePerson.Size = new Size(100, 23);
            textBoxFeePerson.TabIndex = 5;
            // 
            // textBoxCostPerson
            // 
            textBoxCostPerson.Location = new Point(172, 58);
            textBoxCostPerson.Name = "textBoxCostPerson";
            textBoxCostPerson.Size = new Size(100, 23);
            textBoxCostPerson.TabIndex = 4;
            // 
            // textBoxMaxGuest
            // 
            textBoxMaxGuest.Location = new Point(172, 29);
            textBoxMaxGuest.Name = "textBoxMaxGuest";
            textBoxMaxGuest.Size = new Size(100, 23);
            textBoxMaxGuest.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 95);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "Fee per person";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 61);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Cost per person";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 32);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Max Guests";
            // 
            // groupBoxInvite
            // 
            groupBoxInvite.Controls.Add(comboBoxCountry);
            groupBoxInvite.Controls.Add(textBoxPostCode);
            groupBoxInvite.Controls.Add(label14);
            groupBoxInvite.Controls.Add(label15);
            groupBoxInvite.Controls.Add(label16);
            groupBoxInvite.Controls.Add(textBoxCity);
            groupBoxInvite.Controls.Add(textBoxStreet);
            groupBoxInvite.Controls.Add(label7);
            groupBoxInvite.Controls.Add(label12);
            groupBoxInvite.Controls.Add(label13);
            groupBoxInvite.Controls.Add(buttonAdd);
            groupBoxInvite.Controls.Add(textBoxLastName);
            groupBoxInvite.Controls.Add(textBoxFirstName);
            groupBoxInvite.Controls.Add(label4);
            groupBoxInvite.Controls.Add(label5);
            groupBoxInvite.Controls.Add(label6);
            groupBoxInvite.Location = new Point(87, 288);
            groupBoxInvite.Name = "groupBoxInvite";
            groupBoxInvite.Size = new Size(306, 291);
            groupBoxInvite.TabIndex = 7;
            groupBoxInvite.TabStop = false;
            groupBoxInvite.Text = "Inivte Guest";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(172, 228);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 23);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(172, 58);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(100, 23);
            textBoxLastName.TabIndex = 4;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(172, 29);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(100, 23);
            textBoxFirstName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 95);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 61);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 1;
            label5.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 32);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 0;
            label6.Text = "First Name";
            // 
            // guestList
            // 
            guestList.FormattingEnabled = true;
            guestList.ItemHeight = 15;
            guestList.Location = new Point(463, 98);
            guestList.Name = "guestList";
            guestList.Size = new Size(596, 199);
            guestList.TabIndex = 8;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(463, 69);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 7;
            labelName.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 24);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 7;
            label8.Text = "Number of guests";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 59);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 9;
            label9.Text = "Total cost";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 96);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 10;
            label10.Text = "Total fees";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 135);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 11;
            label11.Text = "Surplus/deficit";
            // 
            // labelNumGuest
            // 
            labelNumGuest.AutoSize = true;
            labelNumGuest.BorderStyle = BorderStyle.Fixed3D;
            labelNumGuest.Location = new Point(171, 22);
            labelNumGuest.Name = "labelNumGuest";
            labelNumGuest.Size = new Size(2, 17);
            labelNumGuest.TabIndex = 12;
            // 
            // labelTotalCost
            // 
            labelTotalCost.AutoSize = true;
            labelTotalCost.BorderStyle = BorderStyle.Fixed3D;
            labelTotalCost.Location = new Point(171, 57);
            labelTotalCost.Name = "labelTotalCost";
            labelTotalCost.Size = new Size(2, 17);
            labelTotalCost.TabIndex = 13;
            // 
            // labelTotalFee
            // 
            labelTotalFee.AutoSize = true;
            labelTotalFee.BorderStyle = BorderStyle.Fixed3D;
            labelTotalFee.Location = new Point(171, 94);
            labelTotalFee.Name = "labelTotalFee";
            labelTotalFee.Size = new Size(2, 17);
            labelTotalFee.TabIndex = 14;
            // 
            // labelSurplus
            // 
            labelSurplus.AutoSize = true;
            labelSurplus.BorderStyle = BorderStyle.Fixed3D;
            labelSurplus.Location = new Point(171, 135);
            labelSurplus.Name = "labelSurplus";
            labelSurplus.Size = new Size(2, 17);
            labelSurplus.TabIndex = 15;
            // 
            // buttonDelete
            // 
            buttonDelete.ForeColor = Color.Red;
            buttonDelete.Location = new Point(984, 316);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(758, 69);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(49, 15);
            labelAddress.TabIndex = 17;
            labelAddress.Text = "Address";
            // 
            // buttonChange
            // 
            buttonChange.ForeColor = Color.Black;
            buttonChange.Location = new Point(888, 316);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(75, 23);
            buttonChange.TabIndex = 18;
            buttonChange.Text = "Change";
            buttonChange.UseVisualStyleBackColor = true;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(172, 123);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(100, 23);
            textBoxCity.TabIndex = 11;
            // 
            // textBoxStreet
            // 
            textBoxStreet.Location = new Point(172, 94);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(100, 23);
            textBoxStreet.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 160);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(38, 126);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 8;
            label12.Text = "City";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(38, 97);
            label13.Name = "label13";
            label13.Size = new Size(37, 15);
            label13.TabIndex = 7;
            label13.Text = "Street";
            // 
            // textBoxPostCode
            // 
            textBoxPostCode.Location = new Point(172, 155);
            textBoxPostCode.Name = "textBoxPostCode";
            textBoxPostCode.Size = new Size(100, 23);
            textBoxPostCode.TabIndex = 15;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(38, 221);
            label14.Name = "label14";
            label14.Size = new Size(0, 15);
            label14.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(38, 187);
            label15.Name = "label15";
            label15.Size = new Size(50, 15);
            label15.TabIndex = 13;
            label15.Text = "Country";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(38, 158);
            label16.Name = "label16";
            label16.Size = new Size(61, 15);
            label16.TabIndex = 12;
            label16.Text = "Post Code";
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(172, 187);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(100, 23);
            comboBoxCountry.TabIndex = 17;
            // 
            // groupBoxEco
            // 
            groupBoxEco.Controls.Add(label10);
            groupBoxEco.Controls.Add(label8);
            groupBoxEco.Controls.Add(label9);
            groupBoxEco.Controls.Add(label11);
            groupBoxEco.Controls.Add(labelSurplus);
            groupBoxEco.Controls.Add(labelNumGuest);
            groupBoxEco.Controls.Add(labelTotalFee);
            groupBoxEco.Controls.Add(labelTotalCost);
            groupBoxEco.Location = new Point(859, 366);
            groupBoxEco.Name = "groupBoxEco";
            groupBoxEco.Size = new Size(200, 173);
            groupBoxEco.TabIndex = 19;
            groupBoxEco.TabStop = false;
            groupBoxEco.Text = "Event Economy";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 648);
            Controls.Add(groupBoxEco);
            Controls.Add(buttonChange);
            Controls.Add(labelAddress);
            Controls.Add(buttonDelete);
            Controls.Add(labelName);
            Controls.Add(guestList);
            Controls.Add(groupBoxInvite);
            Controls.Add(groupBoxNewParty);
            Name = "MainForm";
            Text = "Nora Hammenberg";
            groupBoxNewParty.ResumeLayout(false);
            groupBoxNewParty.PerformLayout();
            groupBoxInvite.ResumeLayout(false);
            groupBoxInvite.PerformLayout();
            groupBoxEco.ResumeLayout(false);
            groupBoxEco.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxNewParty;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxFeePerson;
        private TextBox textBoxCostPerson;
        private TextBox textBoxMaxGuest;
        private Button buttonCreate;
        private GroupBox groupBoxInvite;
        private Button buttonAdd;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox guestList;
        private Label labelName;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label labelNumGuest;
        private Label labelTotalCost;
        private Label labelTotalFee;
        private Label labelSurplus;
        private Button buttonDelete;
        private Label labelAddress;
        private ComboBox comboBoxCountry;
        private TextBox textBoxPostCode;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox textBoxCity;
        private TextBox textBoxStreet;
        private Label label7;
        private Label label12;
        private Label label13;
        private Button buttonChange;
        private GroupBox groupBoxEco;
    }
}

#endregion