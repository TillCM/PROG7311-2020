namespace ConsumeJSONV2
{
    partial class CASSUI
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
            this.btn_pullJSON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_pullJSON
            // 
            this.btn_pullJSON.Location = new System.Drawing.Point(382, 356);
            this.btn_pullJSON.Name = "btn_pullJSON";
            this.btn_pullJSON.Size = new System.Drawing.Size(75, 23);
            this.btn_pullJSON.TabIndex = 0;
            this.btn_pullJSON.Text = "Pull JSON";
            this.btn_pullJSON.UseVisualStyleBackColor = true;
            this.btn_pullJSON.Click += new System.EventHandler(this.btn_pullJSON_Click);
            // 
            // CASSUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_pullJSON);
            this.Name = "CASSUI";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pullJSON;
    }
}

