
namespace WeatherConcurrencyApp
{
    partial class WeatherPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.flpContent);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 551);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 337F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblTemperature, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCity, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWeather, 0, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Yellow;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(477, 160);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(164, 138);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTemperature.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(3, 59);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(87, 59);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "30";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCity.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(3, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(60, 59);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.Location = new System.Drawing.Point(3, 118);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(85, 20);
            this.lblWeather.TabIndex = 2;
            this.lblWeather.Text = "lblWeather";
            this.lblWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpContent
            // 
            this.flpContent.BackColor = System.Drawing.Color.Transparent;
            this.flpContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpContent.Location = new System.Drawing.Point(0, 0);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(419, 551);
            this.flpContent.TabIndex = 6;
            // 
            // WeatherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "WeatherPanel";
            this.Size = new System.Drawing.Size(682, 551);
            this.Load += new System.EventHandler(this.WeatherPanel_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
    }
}
