namespace nas
{
    partial class 클라우드메인
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.다운로드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.업로드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공유ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.파일명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.업로드일자 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.파일유형 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.크기 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.상태 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.다운로드ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.이동ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.공유ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 24);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("문체부 돋음체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.다운로드ToolStripMenuItem,
            this.삭제ToolStripMenuItem,
            this.이동ToolStripMenuItem,
            this.공유ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 다운로드ToolStripMenuItem
            // 
            this.다운로드ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.업로드ToolStripMenuItem,
            this.다운로드ToolStripMenuItem1,
            this.삭제ToolStripMenuItem1,
            this.이동ToolStripMenuItem1,
            this.공유ToolStripMenuItem1});
            this.다운로드ToolStripMenuItem.Name = "다운로드ToolStripMenuItem";
            this.다운로드ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.다운로드ToolStripMenuItem.Text = "다운로드";
            // 
            // 업로드ToolStripMenuItem
            // 
            this.업로드ToolStripMenuItem.Name = "업로드ToolStripMenuItem";
            this.업로드ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.업로드ToolStripMenuItem.Text = "업로드";
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.삭제ToolStripMenuItem.Text = "삭제";
            // 
            // 이동ToolStripMenuItem
            // 
            this.이동ToolStripMenuItem.Name = "이동ToolStripMenuItem";
            this.이동ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.이동ToolStripMenuItem.Text = "이동";
            // 
            // 공유ToolStripMenuItem
            // 
            this.공유ToolStripMenuItem.Name = "공유ToolStripMenuItem";
            this.공유ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.공유ToolStripMenuItem.Text = "공유";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.파일명,
            this.업로드일자,
            this.파일유형,
            this.크기,
            this.상태});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(624, 284);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 파일명
            // 
            this.파일명.Text = "파일명";
            this.파일명.Width = 120;
            // 
            // 업로드일자
            // 
            this.업로드일자.Text = "업로드 일자";
            this.업로드일자.Width = 120;
            // 
            // 파일유형
            // 
            this.파일유형.Text = "파일 유형";
            this.파일유형.Width = 120;
            // 
            // 크기
            // 
            this.크기.Text = "크기";
            this.크기.Width = 120;
            // 
            // 상태
            // 
            this.상태.Text = "상태";
            this.상태.Width = 120;
            // 
            // 다운로드ToolStripMenuItem1
            // 
            this.다운로드ToolStripMenuItem1.Name = "다운로드ToolStripMenuItem1";
            this.다운로드ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.다운로드ToolStripMenuItem1.Text = "다운로드";
            // 
            // 삭제ToolStripMenuItem1
            // 
            this.삭제ToolStripMenuItem1.Name = "삭제ToolStripMenuItem1";
            this.삭제ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.삭제ToolStripMenuItem1.Text = "삭제";
            // 
            // 이동ToolStripMenuItem1
            // 
            this.이동ToolStripMenuItem1.Name = "이동ToolStripMenuItem1";
            this.이동ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.이동ToolStripMenuItem1.Text = "이동";
            // 
            // 공유ToolStripMenuItem1
            // 
            this.공유ToolStripMenuItem1.Name = "공유ToolStripMenuItem1";
            this.공유ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.공유ToolStripMenuItem1.Text = "공유";
            // 
            // 클라우드메인
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 308);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "클라우드메인";
            this.Text = "클라우드 메인-닉네임";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 파일명;
        private System.Windows.Forms.ColumnHeader 업로드일자;
        private System.Windows.Forms.ColumnHeader 파일유형;
        private System.Windows.Forms.ColumnHeader 크기;
        private System.Windows.Forms.ColumnHeader 상태;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 다운로드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 업로드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 공유ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다운로드ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 이동ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 공유ToolStripMenuItem1;
    }
}