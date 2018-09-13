namespace _02._2_CoinTossin02
{
    partial class FrmCoinTossing02
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnExercise = new System.Windows.Forms.Button();
            this.LstView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnExercise
            // 
            this.BtnExercise.Location = new System.Drawing.Point(187, 301);
            this.BtnExercise.Name = "BtnExercise";
            this.BtnExercise.Size = new System.Drawing.Size(166, 32);
            this.BtnExercise.TabIndex = 0;
            this.BtnExercise.Text = "Exercise 2";
            this.BtnExercise.UseVisualStyleBackColor = true;
            this.BtnExercise.Click += new System.EventHandler(this.BtnExercise_Click);
            // 
            // LstView
            // 
            this.LstView.Location = new System.Drawing.Point(74, 21);
            this.LstView.Name = "LstView";
            this.LstView.Size = new System.Drawing.Size(386, 256);
            this.LstView.TabIndex = 1;
            this.LstView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 371);
            this.Controls.Add(this.LstView);
            this.Controls.Add(this.BtnExercise);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExercise;
        private System.Windows.Forms.ListView LstView;
    }
}

