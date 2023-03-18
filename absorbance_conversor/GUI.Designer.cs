namespace absorbance_factor_conversor
{
    partial class Gui
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
            this.firstValueInput = new System.Windows.Forms.TextBox();
            this.firstValueLabel = new System.Windows.Forms.Label();
            this.secondValueInput = new System.Windows.Forms.TextBox();
            this.secondValueLabel = new System.Windows.Forms.Label();
            this.thirdValueLabel = new System.Windows.Forms.Label();
            this.thirdValueInput = new System.Windows.Forms.TextBox();
            this.modeSelector = new System.Windows.Forms.ComboBox();
            this.modeSelectorLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.xtechLogoPicture = new System.Windows.Forms.PictureBox();
            this.resultField = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xtechLogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // firstValueInput
            // 
            this.firstValueInput.Location = new System.Drawing.Point(12, 126);
            this.firstValueInput.Name = "firstValueInput";
            this.firstValueInput.Size = new System.Drawing.Size(202, 31);
            this.firstValueInput.TabIndex = 0;
            this.firstValueInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstValueLabel
            // 
            this.firstValueLabel.AutoSize = true;
            this.firstValueLabel.Location = new System.Drawing.Point(12, 98);
            this.firstValueLabel.Name = "firstValueLabel";
            this.firstValueLabel.Size = new System.Drawing.Size(125, 25);
            this.firstValueLabel.TabIndex = 1;
            this.firstValueLabel.Text = "firstValueLabel";
            // 
            // secondValueInput
            // 
            this.secondValueInput.Location = new System.Drawing.Point(12, 212);
            this.secondValueInput.Name = "secondValueInput";
            this.secondValueInput.Size = new System.Drawing.Size(202, 31);
            this.secondValueInput.TabIndex = 2;
            this.secondValueInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondValueLabel
            // 
            this.secondValueLabel.AutoSize = true;
            this.secondValueLabel.Location = new System.Drawing.Point(12, 184);
            this.secondValueLabel.Name = "secondValueLabel";
            this.secondValueLabel.Size = new System.Drawing.Size(152, 25);
            this.secondValueLabel.TabIndex = 3;
            this.secondValueLabel.Text = "secondValueLabel";
            // 
            // thirdValueLabel
            // 
            this.thirdValueLabel.AutoSize = true;
            this.thirdValueLabel.Location = new System.Drawing.Point(12, 259);
            this.thirdValueLabel.Name = "thirdValueLabel";
            this.thirdValueLabel.Size = new System.Drawing.Size(132, 25);
            this.thirdValueLabel.TabIndex = 4;
            this.thirdValueLabel.Text = "thirdValueLabel";
            // 
            // thirdValueInput
            // 
            this.thirdValueInput.Location = new System.Drawing.Point(12, 287);
            this.thirdValueInput.Name = "thirdValueInput";
            this.thirdValueInput.Size = new System.Drawing.Size(202, 31);
            this.thirdValueInput.TabIndex = 5;
            this.thirdValueInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modeSelector
            // 
            this.modeSelector.FormattingEnabled = true;
            this.modeSelector.Location = new System.Drawing.Point(12, 43);
            this.modeSelector.Name = "modeSelector";
            this.modeSelector.Size = new System.Drawing.Size(202, 33);
            this.modeSelector.TabIndex = 6;
            this.modeSelector.SelectedIndexChanged += new System.EventHandler(this.ModeSelector_SelectedIndexChanged);
            // 
            // modeSelectorLabel
            // 
            this.modeSelectorLabel.AutoSize = true;
            this.modeSelectorLabel.Location = new System.Drawing.Point(12, 15);
            this.modeSelectorLabel.Name = "modeSelectorLabel";
            this.modeSelectorLabel.Size = new System.Drawing.Size(58, 25);
            this.modeSelectorLabel.TabIndex = 7;
            this.modeSelectorLabel.Text = "Obter";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(273, 287);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 34);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calcular";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // xtechLogoPicture
            // 
            this.xtechLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("xtechLogoPicture.Image")));
            this.xtechLogoPicture.Location = new System.Drawing.Point(250, 21);
            this.xtechLogoPicture.Name = "xtechLogoPicture";
            this.xtechLogoPicture.Size = new System.Drawing.Size(150, 102);
            this.xtechLogoPicture.TabIndex = 9;
            this.xtechLogoPicture.TabStop = false;
            this.xtechLogoPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // resultField
            // 
            this.resultField.Location = new System.Drawing.Point(273, 249);
            this.resultField.Name = "resultField";
            this.resultField.ReadOnly = true;
            this.resultField.Size = new System.Drawing.Size(112, 31);
            this.resultField.TabIndex = 10;
            this.resultField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(283, 221);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(90, 25);
            this.resultLabel.TabIndex = 11;
            this.resultLabel.Text = "Resultado";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(412, 333);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultField);
            this.Controls.Add(this.xtechLogoPicture);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.modeSelectorLabel);
            this.Controls.Add(this.modeSelector);
            this.Controls.Add(this.thirdValueInput);
            this.Controls.Add(this.thirdValueLabel);
            this.Controls.Add(this.secondValueLabel);
            this.Controls.Add(this.secondValueInput);
            this.Controls.Add(this.firstValueLabel);
            this.Controls.Add(this.firstValueInput);
            this.Name = "Gui";
            this.Text = "Conversor de Abs e K";
            this.Load += new System.EventHandler(this.ModeSelectorLoad);
            ((System.ComponentModel.ISupportInitialize)(this.xtechLogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox firstValueInput;
        private Label firstValueLabel;
        private TextBox secondValueInput;
        private Label secondValueLabel;
        private Label thirdValueLabel;
        private TextBox thirdValueInput;
        private ComboBox modeSelector;
        private Label modeSelectorLabel;
        private Button calculateButton;
        private PictureBox xtechLogoPicture;
        private TextBox resultField;
        private Label resultLabel;
    }
}