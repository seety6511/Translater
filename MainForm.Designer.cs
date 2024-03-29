﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace Translerater
{
    partial class MainForm
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
            this.BeforeTranslate = new System.Windows.Forms.TextBox();
            this.AfterTranslate = new System.Windows.Forms.TextBox();
            this.TranslateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BeforeLabel = new System.Windows.Forms.Label();
            this.AfterLabel = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.HelpB = new System.Windows.Forms.Button();
            this.FileSelectButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TranslateResult = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BeforeTranslate
            // 
            this.BeforeTranslate.Location = new System.Drawing.Point(12, 45);
            this.BeforeTranslate.Multiline = true;
            this.BeforeTranslate.Name = "BeforeTranslate";
            this.BeforeTranslate.Size = new System.Drawing.Size(244, 257);
            this.BeforeTranslate.TabIndex = 0;
            // 
            // AfterTranslate
            // 
            this.AfterTranslate.Location = new System.Drawing.Point(264, 45);
            this.AfterTranslate.Multiline = true;
            this.AfterTranslate.Name = "AfterTranslate";
            this.AfterTranslate.Size = new System.Drawing.Size(237, 257);
            this.AfterTranslate.TabIndex = 1;
            // 
            // TranslateButton
            // 
            this.TranslateButton.Location = new System.Drawing.Point(262, 325);
            this.TranslateButton.Name = "TranslateButton";
            this.TranslateButton.Size = new System.Drawing.Size(75, 23);
            this.TranslateButton.TabIndex = 2;
            this.TranslateButton.Text = "번역";
            this.TranslateButton.UseVisualStyleBackColor = true;
            this.TranslateButton.Click += new System.EventHandler(this.TranslateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(343, 325);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "저장";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BeforeLabel
            // 
            this.BeforeLabel.AutoSize = true;
            this.BeforeLabel.Location = new System.Drawing.Point(10, 22);
            this.BeforeLabel.Name = "BeforeLabel";
            this.BeforeLabel.Size = new System.Drawing.Size(45, 12);
            this.BeforeLabel.TabIndex = 4;
            this.BeforeLabel.Text = "번역 전";
            // 
            // AfterLabel
            // 
            this.AfterLabel.AutoSize = true;
            this.AfterLabel.Location = new System.Drawing.Point(262, 22);
            this.AfterLabel.Name = "AfterLabel";
            this.AfterLabel.Size = new System.Drawing.Size(45, 12);
            this.AfterLabel.TabIndex = 5;
            this.AfterLabel.Text = "번역 후";
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(12, 356);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(244, 21);
            this.FilePath.TabIndex = 6;
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(12, 341);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(149, 12);
            this.FilePathLabel.TabIndex = 7;
            this.FilePathLabel.Text = "번역하고 싶은 텍스트 파일";
            // 
            // HelpB
            // 
            this.HelpB.Location = new System.Drawing.Point(343, 356);
            this.HelpB.Name = "HelpB";
            this.HelpB.Size = new System.Drawing.Size(75, 23);
            this.HelpB.TabIndex = 8;
            this.HelpB.Text = "Help";
            this.HelpB.UseVisualStyleBackColor = true;
            this.HelpB.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // FileSelectButton
            // 
            this.FileSelectButton.Location = new System.Drawing.Point(262, 356);
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.Size = new System.Drawing.Size(75, 23);
            this.FileSelectButton.TabIndex = 9;
            this.FileSelectButton.Text = "파일 선택";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(424, 325);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "비우기";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TranslateResult
            // 
            this.TranslateResult.FormattingEnabled = true;
            this.TranslateResult.Items.AddRange(new object[] {
            "영어",
            "한국어",
            "일어"});
            this.TranslateResult.Location = new System.Drawing.Point(378, 19);
            this.TranslateResult.Name = "TranslateResult";
            this.TranslateResult.Size = new System.Drawing.Size(121, 20);
            this.TranslateResult.TabIndex = 12;
            this.TranslateResult.Text = "영어";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 394);
            this.Controls.Add(this.TranslateResult);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.FileSelectButton);
            this.Controls.Add(this.HelpB);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.AfterLabel);
            this.Controls.Add(this.BeforeLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TranslateButton);
            this.Controls.Add(this.AfterTranslate);
            this.Controls.Add(this.BeforeTranslate);
            this.Name = "MainForm";
            this.Text = "Translater";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox BeforeTranslate;
        private System.Windows.Forms.TextBox AfterTranslate;
        private System.Windows.Forms.Button TranslateButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label BeforeLabel;
        private System.Windows.Forms.Label AfterLabel;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.Button HelpB;
        private System.Windows.Forms.Button FileSelectButton;
        private System.Windows.Forms.Button ClearButton;
        private ComboBox TranslateResult;
    }
}
