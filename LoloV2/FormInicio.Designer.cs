
namespace LoloV2
{
    partial class FormInicio
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAreas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAccess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblfechayhora = new System.Windows.Forms.Label();
            this.horayfecha = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnAreas);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnAccess);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(495, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 100);
            this.button2.TabIndex = 25;
            this.button2.Text = "Grafico";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAreas
            // 
            this.btnAreas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAreas.Location = new System.Drawing.Point(330, 0);
            this.btnAreas.Name = "btnAreas";
            this.btnAreas.Size = new System.Drawing.Size(165, 100);
            this.btnAreas.TabIndex = 24;
            this.btnAreas.Text = "AREAS";
            this.btnAreas.UseVisualStyleBackColor = true;
            this.btnAreas.Click += new System.EventHandler(this.btnAreas_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(165, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 100);
            this.button1.TabIndex = 23;
            this.button1.Text = "MUSICA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccess.Location = new System.Drawing.Point(0, 0);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(165, 100);
            this.btnAccess.TabIndex = 22;
            this.btnAccess.Text = "ACESS";
            this.btnAccess.UseVisualStyleBackColor = true;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "PROGRAMACIÓN LOGICA Y FUNCIONAL";
            // 
            // lblfechayhora
            // 
            this.lblfechayhora.AutoSize = true;
            this.lblfechayhora.Location = new System.Drawing.Point(12, 53);
            this.lblfechayhora.Name = "lblfechayhora";
            this.lblfechayhora.Size = new System.Drawing.Size(178, 20);
            this.lblfechayhora.TabIndex = 26;
            this.lblfechayhora.Text = "aqui va fecha y hora jeje";
            // 
            // horayfecha
            // 
            this.horayfecha.Tick += new System.EventHandler(this.horayfecha_Tick);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblfechayhora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInicio";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAccess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfechayhora;
        private System.Windows.Forms.Timer horayfecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAreas;
        private System.Windows.Forms.Button button2;
    }
}