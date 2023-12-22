namespace WeatherApp
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
        private void InitializeComponent()
        {
            txtCity = new TextBox();
            lblCity = new Label();
            lblDescription = new Label();
            lblTemperature = new Label();
            btnGetWeather = new Button();
            cboLanguage = new ComboBox();
            lblHumadity = new Label();
            lblPressure = new Label();
            lblCountry = new Label();
            SuspendLayout();
            // 
            // txtCity
            // 
            txtCity.Location = new Point(153, 128);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(203, 27);
            txtCity.TabIndex = 0;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(233, 13);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(34, 20);
            lblCity.TabIndex = 1;
            lblCity.Text = "City";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 56);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Location = new Point(9, 13);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(93, 20);
            lblTemperature.TabIndex = 3;
            lblTemperature.Text = "Temperature";
            // 
            // btnGetWeather
            // 
            btnGetWeather.Location = new Point(12, 161);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(344, 50);
            btnGetWeather.TabIndex = 4;
            btnGetWeather.Text = "Get-Weather";
            btnGetWeather.UseVisualStyleBackColor = true;
            btnGetWeather.Click += btnGetWeather_Click;
            // 
            // cboLanguage
            // 
            cboLanguage.FormattingEnabled = true;
            cboLanguage.Location = new Point(12, 127);
            cboLanguage.Name = "cboLanguage";
            cboLanguage.Size = new Size(135, 28);
            cboLanguage.TabIndex = 5;
            cboLanguage.Text = "Language";
            // 
            // lblHumadity
            // 
            lblHumadity.AutoSize = true;
            lblHumadity.Location = new Point(233, 90);
            lblHumadity.Name = "lblHumadity";
            lblHumadity.Size = new Size(74, 20);
            lblHumadity.TabIndex = 6;
            lblHumadity.Text = "Humadity";
            // 
            // lblPressure
            // 
            lblPressure.AutoSize = true;
            lblPressure.Location = new Point(12, 90);
            lblPressure.Name = "lblPressure";
            lblPressure.Size = new Size(63, 20);
            lblPressure.TabIndex = 7;
            lblPressure.Text = "Pressure";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(233, 56);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(60, 20);
            lblCountry.TabIndex = 8;
            lblCountry.Text = "Country";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(368, 222);
            Controls.Add(lblCountry);
            Controls.Add(lblPressure);
            Controls.Add(lblHumadity);
            Controls.Add(cboLanguage);
            Controls.Add(btnGetWeather);
            Controls.Add(lblTemperature);
            Controls.Add(lblDescription);
            Controls.Add(lblCity);
            Controls.Add(txtCity);
            Name = "MainForm";
            Text = "WeatherApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCity;
        private Label lblCity;
        private Label lblDescription;
        private Label lblTemperature;
        private Button btnGetWeather;
        private ComboBox cboLanguage;
        private Label lblHumadity;
        private Label lblPressure;
        private Label lblCountry;
    }
}