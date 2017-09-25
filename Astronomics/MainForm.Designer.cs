/*
 * Сделано в SharpDevelop.
 * Пользователь: suvoroda
 * Дата: 06/03/2015
 * Время: 17:25
 */
namespace Astronomics
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.components = new System.ComponentModel.Container();
			this.ListOuterBody = new System.Windows.Forms.DataGridView();
			this.AddOuterBody = new System.Windows.Forms.Button();
			this.TypeBodyF = new System.Windows.Forms.ComboBox();
			this.TypeBody = new System.Windows.Forms.Label();
			this.NameBody = new System.Windows.Forms.Label();
			this.NameBodyF = new System.Windows.Forms.TextBox();
			this.RadiusBodyF = new System.Windows.Forms.MaskedTextBox();
			this.MassaBodyF = new System.Windows.Forms.MaskedTextBox();
			this.ChangedF = new System.Windows.Forms.MaskedTextBox();
			this.SpeedRotationF = new System.Windows.Forms.MaskedTextBox();
			this.RadiusBody = new System.Windows.Forms.Label();
			this.MassaBody = new System.Windows.Forms.Label();
			this.Changed = new System.Windows.Forms.Label();
			this.SpeedRotation = new System.Windows.Forms.Label();
			this.ListOuterBodyBinding = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ListOuterBody)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ListOuterBodyBinding)).BeginInit();
			this.SuspendLayout();
			// 
			// ListOuterBody
			// 
			this.ListOuterBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ListOuterBody.Location = new System.Drawing.Point(12, 12);
			this.ListOuterBody.Name = "ListOuterBody";
			this.ListOuterBody.Size = new System.Drawing.Size(645, 305);
			this.ListOuterBody.TabIndex = 0;
			// 
			// AddOuterBody
			// 
			this.AddOuterBody.Location = new System.Drawing.Point(12, 490);
			this.AddOuterBody.Name = "AddOuterBody";
			this.AddOuterBody.Size = new System.Drawing.Size(139, 37);
			this.AddOuterBody.TabIndex = 1;
			this.AddOuterBody.Text = "Добавить космическое тело";
			this.AddOuterBody.UseVisualStyleBackColor = true;
			this.AddOuterBody.Click += new System.EventHandler(this.AddOuterBodyClick);
			// 
			// TypeBodyF
			// 
			this.TypeBodyF.FormattingEnabled = true;
			this.TypeBodyF.Location = new System.Drawing.Point(12, 333);
			this.TypeBodyF.Name = "TypeBodyF";
			this.TypeBodyF.Size = new System.Drawing.Size(139, 21);
			this.TypeBodyF.TabIndex = 2;
			// 
			// TypeBody
			// 
			this.TypeBody.Location = new System.Drawing.Point(157, 336);
			this.TypeBody.Name = "TypeBody";
			this.TypeBody.Size = new System.Drawing.Size(100, 18);
			this.TypeBody.TabIndex = 5;
			this.TypeBody.Text = "Тип тела";
			// 
			// NameBody
			// 
			this.NameBody.Location = new System.Drawing.Point(157, 360);
			this.NameBody.Name = "NameBody";
			this.NameBody.Size = new System.Drawing.Size(100, 20);
			this.NameBody.TabIndex = 6;
			this.NameBody.Text = "Имя тела";
			// 
			// NameBodyF
			// 
			this.NameBodyF.Location = new System.Drawing.Point(12, 360);
			this.NameBodyF.Name = "NameBodyF";
			this.NameBodyF.Size = new System.Drawing.Size(139, 20);
			this.NameBodyF.TabIndex = 7;
			this.NameBodyF.Text = "Земля";
			// 
			// RadiusBodyF
			// 
			this.RadiusBodyF.Location = new System.Drawing.Point(12, 386);
			this.RadiusBodyF.Name = "RadiusBodyF";
			this.RadiusBodyF.Size = new System.Drawing.Size(139, 20);
			this.RadiusBodyF.TabIndex = 8;
			this.RadiusBodyF.Text = "123.12";
			this.RadiusBodyF.TextChanged += new System.EventHandler(this.RadiusBodyFTextChanged);
			// 
			// MassaBodyF
			// 
			this.MassaBodyF.Location = new System.Drawing.Point(12, 412);
			this.MassaBodyF.Name = "MassaBodyF";
			this.MassaBodyF.Size = new System.Drawing.Size(139, 20);
			this.MassaBodyF.TabIndex = 9;
			this.MassaBodyF.Text = "12223.12";
			this.MassaBodyF.TextChanged += new System.EventHandler(this.MassaBodyFTextChanged);
			// 
			// ChangedF
			// 
			this.ChangedF.Location = new System.Drawing.Point(12, 464);
			this.ChangedF.Name = "ChangedF";
			this.ChangedF.Size = new System.Drawing.Size(139, 20);
			this.ChangedF.TabIndex = 10;
			this.ChangedF.Text = "333.12";
			this.ChangedF.TextChanged += new System.EventHandler(this.ChangedFTextChanged);
			// 
			// SpeedRotationF
			// 
			this.SpeedRotationF.Location = new System.Drawing.Point(12, 438);
			this.SpeedRotationF.Name = "SpeedRotationF";
			this.SpeedRotationF.Size = new System.Drawing.Size(139, 20);
			this.SpeedRotationF.TabIndex = 11;
			this.SpeedRotationF.Text = "134.12";
			this.SpeedRotationF.TextChanged += new System.EventHandler(this.SpeedRotationFTextChanged);
			// 
			// RadiusBody
			// 
			this.RadiusBody.Location = new System.Drawing.Point(157, 386);
			this.RadiusBody.Name = "RadiusBody";
			this.RadiusBody.Size = new System.Drawing.Size(100, 20);
			this.RadiusBody.TabIndex = 12;
			this.RadiusBody.Text = "Радиус тела";
			// 
			// MassaBody
			// 
			this.MassaBody.Location = new System.Drawing.Point(157, 415);
			this.MassaBody.Name = "MassaBody";
			this.MassaBody.Size = new System.Drawing.Size(100, 17);
			this.MassaBody.TabIndex = 13;
			this.MassaBody.Text = "Масса тела";
			// 
			// Changed
			// 
			this.Changed.Location = new System.Drawing.Point(157, 467);
			this.Changed.Name = "Changed";
			this.Changed.Size = new System.Drawing.Size(100, 17);
			this.Changed.TabIndex = 14;
			this.Changed.Text = "Зависимое поле";
			// 
			// SpeedRotation
			// 
			this.SpeedRotation.Location = new System.Drawing.Point(157, 441);
			this.SpeedRotation.Name = "SpeedRotation";
			this.SpeedRotation.Size = new System.Drawing.Size(140, 20);
			this.SpeedRotation.TabIndex = 15;
			this.SpeedRotation.Text = "Скорость вращения тела";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 539);
			this.Controls.Add(this.SpeedRotation);
			this.Controls.Add(this.Changed);
			this.Controls.Add(this.MassaBody);
			this.Controls.Add(this.RadiusBody);
			this.Controls.Add(this.SpeedRotationF);
			this.Controls.Add(this.ChangedF);
			this.Controls.Add(this.MassaBodyF);
			this.Controls.Add(this.RadiusBodyF);
			this.Controls.Add(this.NameBodyF);
			this.Controls.Add(this.NameBody);
			this.Controls.Add(this.TypeBody);
			this.Controls.Add(this.TypeBodyF);
			this.Controls.Add(this.AddOuterBody);
			this.Controls.Add(this.ListOuterBody);
			this.Name = "MainForm";
			this.Text = "Astronomics";
			((System.ComponentModel.ISupportInitialize)(this.ListOuterBody)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ListOuterBodyBinding)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.BindingSource ListOuterBodyBinding;		
		private System.Windows.Forms.Label SpeedRotation;
		private System.Windows.Forms.Label Changed;
		private System.Windows.Forms.Label MassaBody;
		private System.Windows.Forms.Label RadiusBody;
		private System.Windows.Forms.MaskedTextBox SpeedRotationF;
		private System.Windows.Forms.MaskedTextBox ChangedF;
		private System.Windows.Forms.TextBox NameBodyF;
		private System.Windows.Forms.Label NameBody;
		private System.Windows.Forms.Label TypeBody;
		private System.Windows.Forms.MaskedTextBox MassaBodyF;
		private System.Windows.Forms.MaskedTextBox RadiusBodyF;
		private System.Windows.Forms.ComboBox TypeBodyF;
		private System.Windows.Forms.Button AddOuterBody;
		private System.Windows.Forms.DataGridView ListOuterBody;
	}
}
