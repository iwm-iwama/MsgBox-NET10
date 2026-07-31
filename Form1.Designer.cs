namespace iwm_MsgBox
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			BtnCancel = new Button();
			BtnNo = new Button();
			BtnYes = new Button();
			CbAccept = new CheckBox();
			CmsResult = new ContextMenuStrip(components);
			CmsResult_コピー = new ToolStripMenuItem();
			CmsResult_tss01 = new ToolStripSeparator();
			CmsResult_ネット検索 = new ToolStripMenuItem();
			CmsResult_ネット検索_Google = new ToolStripMenuItem();
			CmsResult_ネット検索_YouTube = new ToolStripMenuItem();
			CmsResult_ネット検索_Wikipedia = new ToolStripMenuItem();
			CmsResult_tss02 = new ToolStripSeparator();
			CmsResult_FontSizeUp = new ToolStripMenuItem();
			CmsResult_FontSizeDn = new ToolStripMenuItem();
			TbResult = new TextBox();
			CmsResult_ネット検索_URLを開く = new ToolStripMenuItem();
			CmsResult_ネット検索_Google翻訳 = new ToolStripMenuItem();
			toolStripMenuItem1 = new ToolStripSeparator();
			CmsResult_関連付けられたアプリケーションで開く = new ToolStripMenuItem();
			CmsResult.SuspendLayout();
			SuspendLayout();
			// 
			// BtnCancel
			// 
			BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			BtnCancel.BackColor = SystemColors.ControlLight;
			BtnCancel.Cursor = Cursors.Hand;
			BtnCancel.FlatAppearance.BorderColor = Color.DarkGray;
			BtnCancel.FlatAppearance.BorderSize = 0;
			BtnCancel.FlatAppearance.CheckedBackColor = Color.DarkGray;
			BtnCancel.FlatAppearance.MouseDownBackColor = Color.Gray;
			BtnCancel.FlatAppearance.MouseOverBackColor = Color.Gray;
			BtnCancel.Font = new Font("ＭＳ Ｐゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
			BtnCancel.ForeColor = SystemColors.ControlText;
			BtnCancel.Location = new Point(507, 408);
			BtnCancel.Margin = new Padding(0);
			BtnCancel.Name = "BtnCancel";
			BtnCancel.Size = new Size(70, 24);
			BtnCancel.TabIndex = 4;
			BtnCancel.Text = "閉じる";
			BtnCancel.UseVisualStyleBackColor = true;
			BtnCancel.Click += BtnCancel_Click;
			// 
			// BtnNo
			// 
			BtnNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			BtnNo.BackColor = SystemColors.ControlLight;
			BtnNo.Cursor = Cursors.Hand;
			BtnNo.FlatAppearance.BorderColor = Color.DarkGray;
			BtnNo.FlatAppearance.BorderSize = 0;
			BtnNo.FlatAppearance.CheckedBackColor = Color.DarkGray;
			BtnNo.FlatAppearance.MouseDownBackColor = Color.Gray;
			BtnNo.FlatAppearance.MouseOverBackColor = Color.Gray;
			BtnNo.Font = new Font("ＭＳ Ｐゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
			BtnNo.ForeColor = SystemColors.ControlText;
			BtnNo.Location = new Point(435, 408);
			BtnNo.Margin = new Padding(0);
			BtnNo.Name = "BtnNo";
			BtnNo.Size = new Size(70, 24);
			BtnNo.TabIndex = 3;
			BtnNo.Text = "いいえ";
			BtnNo.UseVisualStyleBackColor = true;
			BtnNo.Click += BtnNo_Click;
			// 
			// BtnYes
			// 
			BtnYes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			BtnYes.BackColor = SystemColors.ControlLight;
			BtnYes.Cursor = Cursors.Hand;
			BtnYes.FlatAppearance.BorderColor = Color.DarkGray;
			BtnYes.FlatAppearance.BorderSize = 0;
			BtnYes.FlatAppearance.CheckedBackColor = Color.DarkGray;
			BtnYes.FlatAppearance.MouseDownBackColor = Color.Gray;
			BtnYes.FlatAppearance.MouseOverBackColor = Color.Gray;
			BtnYes.Font = new Font("ＭＳ Ｐゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
			BtnYes.ForeColor = SystemColors.ControlText;
			BtnYes.Location = new Point(363, 408);
			BtnYes.Margin = new Padding(0);
			BtnYes.Name = "BtnYes";
			BtnYes.Size = new Size(70, 24);
			BtnYes.TabIndex = 2;
			BtnYes.Text = "はい";
			BtnYes.UseVisualStyleBackColor = true;
			BtnYes.Click += BtnYes_Click;
			// 
			// CbAccept
			// 
			CbAccept.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			CbAccept.AutoSize = true;
			CbAccept.BackColor = SystemColors.Control;
			CbAccept.Checked = true;
			CbAccept.CheckState = CheckState.Checked;
			CbAccept.Cursor = Cursors.Hand;
			CbAccept.Font = new Font("ＭＳ Ｐゴシック", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
			CbAccept.Location = new Point(10, 385);
			CbAccept.Margin = new Padding(0);
			CbAccept.Name = "CbAccept";
			CbAccept.Size = new Size(157, 17);
			CbAccept.TabIndex = 1;
			CbAccept.Text = "上記内容を承諾します。";
			CbAccept.UseVisualStyleBackColor = true;
			CbAccept.CheckedChanged += CbAccept_CheckedChanged;
			// 
			// CmsResult
			// 
			CmsResult.Items.AddRange(new ToolStripItem[] { CmsResult_コピー, CmsResult_tss01, CmsResult_関連付けられたアプリケーションで開く, CmsResult_ネット検索, CmsResult_tss02, CmsResult_FontSizeUp, CmsResult_FontSizeDn });
			CmsResult.Name = "CmsResult";
			CmsResult.Size = new Size(247, 126);
			CmsResult.Paint += CmsResult_Paint;
			// 
			// CmsResult_コピー
			// 
			CmsResult_コピー.Name = "CmsResult_コピー";
			CmsResult_コピー.Size = new Size(246, 22);
			CmsResult_コピー.Text = "コピー";
			CmsResult_コピー.Click += CmsResult_コピー_Click;
			// 
			// CmsResult_tss01
			// 
			CmsResult_tss01.Name = "CmsResult_tss01";
			CmsResult_tss01.Size = new Size(243, 6);
			// 
			// CmsResult_ネット検索
			// 
			CmsResult_ネット検索.DropDownItems.AddRange(new ToolStripItem[] { CmsResult_ネット検索_URLを開く, toolStripMenuItem1, CmsResult_ネット検索_Google, CmsResult_ネット検索_Google翻訳, CmsResult_ネット検索_YouTube, CmsResult_ネット検索_Wikipedia });
			CmsResult_ネット検索.Name = "CmsResult_ネット検索";
			CmsResult_ネット検索.Size = new Size(246, 22);
			CmsResult_ネット検索.Text = "ネット検索";
			// 
			// CmsResult_ネット検索_Google
			// 
			CmsResult_ネット検索_Google.Name = "CmsResult_ネット検索_Google";
			CmsResult_ネット検索_Google.Size = new Size(136, 22);
			CmsResult_ネット検索_Google.Text = "Google";
			CmsResult_ネット検索_Google.Click += CmsResult_ネット検索_Google_Click;
			// 
			// CmsResult_ネット検索_YouTube
			// 
			CmsResult_ネット検索_YouTube.Name = "CmsResult_ネット検索_YouTube";
			CmsResult_ネット検索_YouTube.Size = new Size(136, 22);
			CmsResult_ネット検索_YouTube.Text = "YouTube";
			CmsResult_ネット検索_YouTube.Click += CmsResult_ネット検索_YouTube_Click;
			// 
			// CmsResult_ネット検索_Wikipedia
			// 
			CmsResult_ネット検索_Wikipedia.Name = "CmsResult_ネット検索_Wikipedia";
			CmsResult_ネット検索_Wikipedia.Size = new Size(136, 22);
			CmsResult_ネット検索_Wikipedia.Text = "Wikipedia";
			CmsResult_ネット検索_Wikipedia.Click += CmsResult_ネット検索_Wikipedia_Click;
			// 
			// CmsResult_tss02
			// 
			CmsResult_tss02.Name = "CmsResult_tss02";
			CmsResult_tss02.Size = new Size(243, 6);
			// 
			// CmsResult_FontSizeUp
			// 
			CmsResult_FontSizeUp.Name = "CmsResult_FontSizeUp";
			CmsResult_FontSizeUp.Size = new Size(246, 22);
			CmsResult_FontSizeUp.Text = "フォントを大きくする";
			CmsResult_FontSizeUp.Click += CmsResult_FontSizeUp_Click;
			// 
			// CmsResult_FontSizeDn
			// 
			CmsResult_FontSizeDn.Name = "CmsResult_FontSizeDn";
			CmsResult_FontSizeDn.Size = new Size(246, 22);
			CmsResult_FontSizeDn.Text = "フォントを小さくする";
			CmsResult_FontSizeDn.Click += CmsResult_FontSizeDn_Click;
			// 
			// TbResult
			// 
			TbResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			TbResult.BackColor = Color.White;
			TbResult.BorderStyle = BorderStyle.FixedSingle;
			TbResult.ContextMenuStrip = CmsResult;
			TbResult.Font = new Font("ＭＳ ゴシック", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
			TbResult.ForeColor = Color.Black;
			TbResult.Location = new Point(0, 0);
			TbResult.Margin = new Padding(0);
			TbResult.MaxLength = int.MaxValue;
			TbResult.Multiline = true;
			TbResult.Name = "TbResult";
			TbResult.ReadOnly = true;
			TbResult.ScrollBars = ScrollBars.Both;
			TbResult.Size = new Size(583, 380);
			TbResult.TabIndex = 0;
			TbResult.TabStop = false;
			TbResult.WordWrap = false;
			// 
			// CmsResult_ネット検索_URLを開く
			// 
			CmsResult_ネット検索_URLを開く.Name = "CmsResult_ネット検索_URLを開く";
			CmsResult_ネット検索_URLを開く.Size = new Size(136, 22);
			CmsResult_ネット検索_URLを開く.Text = "URLを開く";
			CmsResult_ネット検索_URLを開く.Click += CmsResult_ネット検索_URLを開く_Click;
			// 
			// CmsResult_ネット検索_Google翻訳
			// 
			CmsResult_ネット検索_Google翻訳.Name = "CmsResult_ネット検索_Google翻訳";
			CmsResult_ネット検索_Google翻訳.Size = new Size(136, 22);
			CmsResult_ネット検索_Google翻訳.Text = "Google翻訳";
			CmsResult_ネット検索_Google翻訳.Click += CmsResult_ネット検索_Google翻訳_Click;
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(133, 6);
			// 
			// CmsResult_関連付けられたアプリケーションで開く
			// 
			CmsResult_関連付けられたアプリケーションで開く.Name = "CmsResult_関連付けられたアプリケーションで開く";
			CmsResult_関連付けられたアプリケーションで開く.Size = new Size(246, 22);
			CmsResult_関連付けられたアプリケーションで開く.Text = "関連付けられたアプリケーションで開く";
			CmsResult_関連付けられたアプリケーションで開く.Click += CmsResult_関連付けられたアプリケーションで開く_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(6F, 12F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(584, 441);
			Controls.Add(BtnYes);
			Controls.Add(BtnNo);
			Controls.Add(BtnCancel);
			Controls.Add(TbResult);
			Controls.Add(CbAccept);
			DoubleBuffered = true;
			Font = new Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
			MinimizeBox = false;
			MinimumSize = new Size(250, 160);
			Name = "Form1";
			ShowIcon = false;
			SizeGripStyle = SizeGripStyle.Hide;
			StartPosition = FormStartPosition.Manual;
			Text = "Form1";
			TopMost = true;
			Load += Form1_Load;
			CmsResult.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnNo;
		private System.Windows.Forms.Button BtnYes;
		private System.Windows.Forms.CheckBox CbAccept;
		private System.Windows.Forms.ContextMenuStrip CmsResult;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_コピー;
		private System.Windows.Forms.ToolStripSeparator CmsResult_tss01;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_ネット検索;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_ネット検索_Google;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_ネット検索_YouTube;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_ネット検索_Wikipedia;
		private System.Windows.Forms.ToolStripSeparator CmsResult_tss02;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_FontSizeUp;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_FontSizeDn;
		private System.Windows.Forms.TextBox TbResult;
		private ToolStripMenuItem CmsResult_ネット検索_URLを開く;
		private ToolStripMenuItem CmsResult_ネット検索_Google翻訳;
		private ToolStripSeparator toolStripMenuItem1;
		private ToolStripMenuItem CmsResult_関連付けられたアプリケーションで開く;
	}
}

