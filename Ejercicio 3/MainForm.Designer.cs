/*
 * Created by SharpDevelop.
 * User: IPPESSI
 * Date: 20/8/2021
 * Time: 21:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio_3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pic_imagen;
		private System.Windows.Forms.Button btn_imagen;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pic_imagen = new System.Windows.Forms.PictureBox();
			this.btn_imagen = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_imagen
			// 
			this.pic_imagen.Location = new System.Drawing.Point(12, 12);
			this.pic_imagen.Name = "pic_imagen";
			this.pic_imagen.Size = new System.Drawing.Size(260, 167);
			this.pic_imagen.TabIndex = 0;
			this.pic_imagen.TabStop = false;
			// 
			// btn_imagen
			// 
			this.btn_imagen.Location = new System.Drawing.Point(109, 208);
			this.btn_imagen.Name = "btn_imagen";
			this.btn_imagen.Size = new System.Drawing.Size(75, 23);
			this.btn_imagen.TabIndex = 1;
			this.btn_imagen.Text = "Imagen";
			this.btn_imagen.UseVisualStyleBackColor = true;
			this.btn_imagen.Click += new System.EventHandler(this.Btn_imagenClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btn_imagen);
			this.Controls.Add(this.pic_imagen);
			this.Name = "MainForm";
			this.Text = "Ejercicio 3";
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
