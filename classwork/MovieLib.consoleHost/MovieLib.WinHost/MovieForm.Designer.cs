
namespace MovieLib.WinHost
{
    partial class MovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
        {
            this.label1 = new System.Windows.Forms.Label();
            this._txtTittle = new System.Windows.Forms.TextBox();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._txtReleaseYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtDuration = new System.Windows.Forms.TextBox();
            this._txtGenre = new System.Windows.Forms.TextBox();
            this._ddlRating = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._chkisClassic = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tittle";
            // 
            // _txtTittle
            // 
            this._txtTittle.Location = new System.Drawing.Point(140, 34);
            this._txtTittle.Name = "_txtTittle";
            this._txtTittle.Size = new System.Drawing.Size(100, 23);
            this._txtTittle.TabIndex = 1;
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(673, 388);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 2;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnMovieAdd);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(566, 388);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 3;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Release Year";
            // 
            // _txtReleaseYear
            // 
            this._txtReleaseYear.Location = new System.Drawing.Point(140, 93);
            this._txtReleaseYear.Name = "_txtReleaseYear";
            this._txtReleaseYear.Size = new System.Drawing.Size(100, 23);
            this._txtReleaseYear.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duration(minutes)";
            // 
            // _txtDuration
            // 
            this._txtDuration.Location = new System.Drawing.Point(140, 164);
            this._txtDuration.Name = "_txtDuration";
            this._txtDuration.Size = new System.Drawing.Size(100, 23);
            this._txtDuration.TabIndex = 7;
            // 
            // _txtGenre
            // 
            this._txtGenre.Location = new System.Drawing.Point(140, 240);
            this._txtGenre.Name = "_txtGenre";
            this._txtGenre.Size = new System.Drawing.Size(100, 23);
            this._txtGenre.TabIndex = 8;
            // 
            // _ddlRating
            // 
            this._ddlRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._ddlRating.FormattingEnabled = true;
            this._ddlRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R"});
            this._ddlRating.Location = new System.Drawing.Point(119, 389);
            this._ddlRating.Name = "_ddlRating";
            this._ddlRating.Size = new System.Drawing.Size(121, 23);
            this._ddlRating.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Description";
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(140, 308);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(239, 60);
            this._txtDescription.TabIndex = 13;
            // 
            // _chkisClassic
            // 
            this._chkisClassic.AutoSize = true;
            this._chkisClassic.Location = new System.Drawing.Point(306, 393);
            this._chkisClassic.Name = "_chkisClassic";
            this._chkisClassic.Size = new System.Drawing.Size(73, 19);
            this._chkisClassic.TabIndex = 14;
            this._chkisClassic.Text = "Is Classic";
            this._chkisClassic.UseVisualStyleBackColor = true;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._chkisClassic);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._ddlRating);
            this.Controls.Add(this._txtGenre);
            this.Controls.Add(this._txtDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtReleaseYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._txtTittle);
            this.Controls.Add(this.label1);
            this.Name = "MovieForm";
            this.Text = "Movie Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtTittle;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtReleaseYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtDuration;
        private System.Windows.Forms.TextBox _txtGenre;
        private System.Windows.Forms.ComboBox _ddlRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.CheckBox _chkisClassic;
    }
}