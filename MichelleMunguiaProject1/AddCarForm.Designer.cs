namespace MichelleMunguiaProject1
{
    partial class AddCarForm
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
            MakeText = new TextBox();
            ModelText = new TextBox();
            MpgText = new TextBox();
            PriceText = new TextBox();
            MakeLabel = new Label();
            ModelLabel = new Label();
            mpgLabel = new Label();
            PriceLabel = new Label();
            AddButton = new Button();
            Cancel = new Button();
            SuspendLayout();
            // 
            // MakeText
            // 
            MakeText.Location = new Point(254, 108);
            MakeText.Name = "MakeText";
            MakeText.Size = new Size(200, 39);
            MakeText.TabIndex = 0;
            // 
            // ModelText
            // 
            ModelText.Location = new Point(254, 187);
            ModelText.Name = "ModelText";
            ModelText.Size = new Size(200, 39);
            ModelText.TabIndex = 1;
            // 
            // MpgText
            // 
            MpgText.Location = new Point(254, 270);
            MpgText.Name = "MpgText";
            MpgText.Size = new Size(200, 39);
            MpgText.TabIndex = 2;
            // 
            // PriceText
            // 
            PriceText.Location = new Point(254, 349);
            PriceText.Name = "PriceText";
            PriceText.Size = new Size(200, 39);
            PriceText.TabIndex = 3;
            // 
            // MakeLabel
            // 
            MakeLabel.AutoSize = true;
            MakeLabel.Location = new Point(121, 108);
            MakeLabel.Name = "MakeLabel";
            MakeLabel.Size = new Size(85, 32);
            MakeLabel.TabIndex = 4;
            MakeLabel.Text = "Make :";
            // 
            // ModelLabel
            // 
            ModelLabel.AutoSize = true;
            ModelLabel.Location = new Point(121, 187);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(95, 32);
            ModelLabel.TabIndex = 5;
            ModelLabel.Text = "Model :";
            // 
            // mpgLabel
            // 
            mpgLabel.AutoSize = true;
            mpgLabel.Location = new Point(121, 270);
            mpgLabel.Name = "mpgLabel";
            mpgLabel.Size = new Size(77, 32);
            mpgLabel.TabIndex = 6;
            mpgLabel.Text = "MPG :";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(121, 349);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(77, 32);
            PriceLabel.TabIndex = 7;
            PriceLabel.Text = "Price :";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(121, 437);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(150, 46);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(304, 437);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(150, 46);
            Cancel.TabIndex = 9;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 535);
            Controls.Add(Cancel);
            Controls.Add(AddButton);
            Controls.Add(PriceLabel);
            Controls.Add(mpgLabel);
            Controls.Add(ModelLabel);
            Controls.Add(MakeLabel);
            Controls.Add(PriceText);
            Controls.Add(MpgText);
            Controls.Add(ModelText);
            Controls.Add(MakeText);
            Name = "AddCarForm";
            Text = "Add Car";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MakeText;
        private TextBox ModelText;
        private TextBox MpgText;
        private TextBox PriceText;
        private Label MakeLabel;
        private Label ModelLabel;
        private Label mpgLabel;
        private Label PriceLabel;
        private Button AddButton;
        private Button Cancel;
    }
}