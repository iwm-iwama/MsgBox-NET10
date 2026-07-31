#pragma warning disable SYSLIB1045

using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Web;

namespace iwm_MsgBox
{
	public partial class Form1 : Form
	{
		private const string VERSION = "iwm_MsgBox";

		private static readonly string NL = Environment.NewLine;
		private const string RgxNL = "\r?\n";

		private static readonly string[] ARGS = Environment.GetCommandLineArgs();
		private static readonly string PROGRAM = Path.GetFileName(ARGS[0]);

		private static readonly int[] TEXTSIZE = [10, 10 * 3];

		private static readonly int[] TbResult_HEIGHT = [0, 0];
		private static readonly int[] BtnYes_POSX = [0, 0];

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// 初期化
			Visible = false;
			StartPosition = FormStartPosition.Manual;
			Location = new Point(Cursor.Position.X - (Width / 2), Cursor.Position.Y - (SystemInformation.CaptionHeight / 2));
			Text = "";

			TbResult.Text = "";
			TbResult_HEIGHT[0] = TbResult.Height;
			TbResult_HEIGHT[1] = TbResult_HEIGHT[0] + 20;

			BtnYes_POSX[0] = BtnYes.Location.X;
			BtnYes_POSX[1] = BtnNo.Location.X;
			BtnYes.Visible = false;
			BtnNo.Visible = false;

			CbAccept.Checked = true;
			CbAccept.Visible = false;

			TbResult.Height = TbResult_HEIGHT[1];

			int iW = Width;
			int iH = Height;

			bool bFormCenter = false;

			// [0] は Program なので読み飛ばす
			for (int _i1 = 1; _i1 < ARGS.Length; _i1++)
			{
				string _s1 = ARGS[_i1];
				string[] _as1;

				if (Regex.IsMatch(_s1, @"^\-size\=\d+\,\d+"))
				{
					_as1 = _s1[6..].Split(',');

					iW = int.Parse(_as1[0]);
					iH = int.Parse(_as1[1]);

					if (iW < MinimumSize.Width)
					{
						iW = MinimumSize.Width;
					}
					else if (iW > Screen.PrimaryScreen!.WorkingArea.Width)
					{
						iW = Screen.PrimaryScreen.WorkingArea.Width;
					}

					if (iH < MinimumSize.Height)
					{
						iH = MinimumSize.Height;
					}
					else if (iH > Screen.PrimaryScreen!.WorkingArea.Height)
					{
						iH = Screen.PrimaryScreen.WorkingArea.Height;
					}
				}
				else if (Regex.IsMatch(_s1, @"^\-title\=.+"))
				{
					Text = _s1[7..];
				}
				else if (Regex.IsMatch(_s1, @"^\-text\=.+"))
				{
					string _s2 = _s1[6..];

					// 特殊文字変換
					_s2 = Regex.Replace(_s2, @"\\\\n|\r*\n", NL);
					_s2 = Regex.Replace(_s2, @"\\\\t", "\t");

					TbResult.Text = _s2;
				}
				else if (Regex.IsMatch(_s1, @"^\-textsize\=\d+"))
				{
					string _s2 = _s1[10..];
					int _i2 = int.Parse(_s2);

					if (_i2 < TEXTSIZE[0])
					{
						_i2 = TEXTSIZE[0];
					}

					if (_i2 > TEXTSIZE[1])
					{
						_i2 = TEXTSIZE[1];
					}

					TbResult.Font = new Font(TbResult.Font.FontFamily, _i2);
				}
				else if (Regex.IsMatch(_s1, @"^\-checkbox\=.*"))
				{
					CbAccept.Text = _s1[10..];
					CbAccept.Checked = false;
					CbAccept.Visible = true;
					TbResult.Height = TbResult_HEIGHT[0];
				}
				else if (Regex.IsMatch(_s1, @"^\-button\=\d+\,\d+"))
				{
					_as1 = _s1[8..].Split(',');
					BtnYes.Visible = int.Parse(_as1[0]) > 0;
					BtnNo.Visible = int.Parse(_as1[1]) > 0;
				}
				else if (Regex.IsMatch(_s1, @"^\-buttontext\=.+\,.+\,.+"))
				{
					_as1 = _s1[12..].Split(',');
					BtnYes.Text = _as1[0];
					BtnNo.Text = _as1[1];
					BtnCancel.Text = _as1[2];
				}
				else if (_s1 == @"-center")
				{
					bFormCenter = true;
				}
			}

			// 再描画
			BtnYes.Enabled = CbAccept.Checked;
			BtnYes.Location = BtnYes.Visible && !BtnNo.Visible ? new Point(BtnYes_POSX[1], BtnYes.Location.Y) : new Point(BtnYes_POSX[0], BtnYes.Location.Y);

			Width = iW;
			Height = iH;

			if (bFormCenter)
			{
				Location = new Point((Screen.GetWorkingArea(this).Width - Width) / 2, (Screen.GetWorkingArea(this).Height - Height) / 2);
			}

			// help
			if (TbResult.TextLength == 0)
			{
				if (Text.Length == 0)
				{
					Text = VERSION;
				}

				TbResult.Text =
					"【使い方】" + NL +
					$"  {PROGRAM} [オプション] ..." + NL +
					NL +
					$"  (例) {PROGRAM} -size={Size.Width},{Size.Height} -title=\"タイトル\" -text=\"あいうえお\\\\nかき\\\\tくけこ\" -textsize={TEXTSIZE[0]} -checkbox=\"上記内容を承諾します。\" -button=1,1 -buttontext=\"はい\",\"いいえ\",\"閉じる\"" + NL +
					NL +
					"【オプション】" + NL +
					"  -size=width,height" + NL +
					$"    (例) {Size.Width},{Size.Height}" + NL +
					NL +
					"  -title=\"\"" + NL +
					"    (例) \"タイトル\"" + NL +
					NL +
					"  -text=\"\"" + NL +
					"    (例) \"あいうえお\\\\nかき\\\\tくけこ\"" + NL +
					"    改行 => \\\\n" + NL +
					"    タブ => \\\\t" + NL +
					NL +
					"  -textsize=n" + NL +
					$"    (例) {TEXTSIZE[0]}" + NL +
					NL +
					"  -checkbox=\"\"" + NL +
					"    (例) \"上記内容を承諾します。\"" + NL +
					NL +
					"  -button=n,n" + NL +
					"    (例)" + NL +
					"      1,1 => [はい] [いいえ] [閉じる]" + NL +
					"      1,0 => [はい] [閉じる]" + NL +
					"      0,1 => [いいえ] [閉じる]" + NL +
					"      0,0 => [閉じる]" + NL +
					NL +
					"  -buttontext=\"\",\"\",\"\"" + NL +
					"    (例) \"はい\",\"いいえ\",\"閉じる\"" + NL +
					NL +
					"  -center" + NL +
					"    画面中央に表示" + NL +
					NL +
					"【戻り値】" + NL +
					"  [はい]   => 1" + NL +
					"  [いいえ] => 2" + NL +
					"  [閉じる] => 0" + NL
				;
			}

			Visible = true;
		}

		private void CbAccept_CheckedChanged(object sender, EventArgs e)
		{
			if (CbAccept.Checked)
			{
				BtnYes.Enabled = true;
				_ = BtnYes.Focus();
			}
			else
			{
				BtnYes.Enabled = false;
				_ = BtnNo.Visible ? BtnNo.Focus() : BtnCancel.Focus();
			}
		}

		private void BtnYes_Click(object sender, EventArgs e)
		{
			Let.Rtn = 1;
			Close();
		}

		private void BtnNo_Click(object sender, EventArgs e)
		{
			Let.Rtn = 2;
			Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Let.Rtn = 0;
			Close();
		}

		private void CmsResult_Paint(object sender, PaintEventArgs e)
		{
			CmsResult_FontSizeUp.Enabled = (int)TbResult.Font.Size < TEXTSIZE[1];
			CmsResult_FontSizeDn.Enabled = (int)TbResult.Font.Size > TEXTSIZE[0];
		}

		private void CmsResult_FontSizeUp_Click(object sender, EventArgs e)
		{
			int i1 = (int)TbResult.Font.Size + 5;

			if (i1 > TEXTSIZE[1])
			{
				i1 = TEXTSIZE[1];
			}

			TbResult.Font = new Font(TbResult.Font.FontFamily, i1);
		}

		private void CmsResult_FontSizeDn_Click(object sender, EventArgs e)
		{
			int i1 = (int)TbResult.Font.Size - 5;

			if (i1 < TEXTSIZE[0])
			{
				i1 = TEXTSIZE[0];
			}

			TbResult.Font = new Font(TbResult.Font.FontFamily, i1);
		}

		private void CmsResult_コピー_Click(object sender, EventArgs e)
		{
			Clipboard.Clear();
			TbResult.Copy();
		}

		private void CmsResult_関連付けられたアプリケーションで開く_Click(object sender, EventArgs e)
		{
			string s1 = "";

			// ActiveControl がコンテナ（Panel等）の場合を考慮し、実際の入力コントロールを取得
			Control currentControl = ActiveControl!;
			while (currentControl is ContainerControl container && container.ActiveControl != null)
			{
				currentControl = container.ActiveControl;
			}

			switch (currentControl)
			{
				case TextBox tb:
					s1 = tb.SelectedText;
					break;
			}

			foreach (string _s1 in Regex.Split(s1.Trim(), RgxNL))
			{
				string target = _s1.Trim();
				if (string.IsNullOrEmpty(target)) continue;

				try
				{
					// .NET Core / .NET 5+ では UseShellExecute = true が必須
					ProcessStartInfo psi = new()
					{
						FileName = target,
						UseShellExecute = true // これがないとファイルやURLを直接開けません
					};
					_ = Process.Start(psi);
				}
				catch (Exception exp)
				{
					M($"[Err] {exp.Message}");
					break;
				}
			}
		}

		private void CmsResult_ネット検索_URLを開く_Click(object sender, EventArgs e)
		{
			CmsResult_関連付けられたアプリケーションで開く_Click(sender, e);
		}

		private void CmsResult_ネット検索_Google_Click(object sender, EventArgs e)
		{
			SubNetSearch("https://www.google.co.jp/search?q=");
		}

		private void CmsResult_ネット検索_Google翻訳_Click(object sender, EventArgs e)
		{
			SubNetSearch("https://translate.google.com/?hl=ja&sl=auto&tl=ja&op=translate&text=");
		}

		private void CmsResult_ネット検索_Googleマップ_Click(object sender, EventArgs e)
		{
			SubNetSearch("https://www.google.co.jp/maps/search/");
		}

		private void CmsResult_ネット検索_YouTube_Click(object sender, EventArgs e)
		{
			SubNetSearch("https://www.youtube.com/results?search_query=");
		}

		private void CmsResult_ネット検索_Wikipedia_Click(object sender, EventArgs e)
		{
			SubNetSearch("https://ja.wikipedia.org/wiki/");
		}

		private void SubNetSearch(string url)
		{
			string s1 = "";

			// コンテナ（Panel等）の奥にあるTextBoxも正しく取得する
			Control currentControl = ActiveControl!;
			while (currentControl is ContainerControl container && container.ActiveControl != null)
			{
				currentControl = container.ActiveControl;
			}

			switch (currentControl)
			{
				case TextBox tb:
					s1 = tb.SelectedText;
					break;
			}

			// URLエンコードと文字列置換
			string targetUrl = url + HttpUtility.UrlEncode(Regex.Replace(s1.Trim(), RgxNL, " "));

			try
			{
				// .NET 5以降（.NET 10含む）では UseShellExecute = true が必須
				ProcessStartInfo psi = new()
				{
					FileName = targetUrl,
					UseShellExecute = true // これがないとURLをブラウザで開けません
				};
				_ = Process.Start(psi);
			}
			catch (Exception exp)
			{
				M($"[Err] {exp.Message}");
			}
		}

		public class Let
		{
			public static int Rtn { get; set; }
		}

		//--------------------------------------------------------------------------------
		// Main()
		//--------------------------------------------------------------------------------
		public class Program
		{
			[STAThread]
			private static void Main()
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());

				Console.Write(Let.Rtn);
			}
		}

		//--------------------------------------------------------------------------------
		// MessageBox
		//--------------------------------------------------------------------------------
		private static void M(object obj)
		{
			_ = MessageBox.Show(
				obj.ToString(),
				AppDomain.CurrentDomain.FriendlyName
			);
		}

	}
}
