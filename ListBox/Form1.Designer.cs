﻿namespace ListBox
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbView = new System.Windows.Forms.ListBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbView
            // 
            this.lbView.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbView.FormattingEnabled = true;
            this.lbView.ItemHeight = 16;
            this.lbView.Location = new System.Drawing.Point(13, 13);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(366, 292);
            this.lbView.TabIndex = 0;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbResult.Location = new System.Drawing.Point(12, 318);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(70, 20);
            this.lbResult.TabIndex = 1;
            this.lbResult.Text = "결과 : ";
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(13, 348);
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(366, 21);
            this.txtList.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(13, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(365, 73);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 465);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "리스트 추가";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbView;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Button btnAdd;
    }
}

