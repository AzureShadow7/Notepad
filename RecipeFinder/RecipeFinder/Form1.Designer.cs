namespace RecipeFinder
{
    partial class RecipeFinder
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
            this.recipeFinderLabel = new System.Windows.Forms.Label();
            this.recipeDataGridView = new System.Windows.Forms.DataGridView();
            this.questionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.specificationLabel = new System.Windows.Forms.Label();
            this.vegetarianCheckBox = new System.Windows.Forms.CheckBox();
            this.cookingTimeComboBox = new System.Windows.Forms.ComboBox();
            this.cookingTimelLabel = new System.Windows.Forms.Label();
            this.prepTimeLabel = new System.Windows.Forms.Label();
            this.prepTimeComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeFinderLabel
            // 
            this.recipeFinderLabel.AutoSize = true;
            this.recipeFinderLabel.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeFinderLabel.ForeColor = System.Drawing.Color.Sienna;
            this.recipeFinderLabel.Location = new System.Drawing.Point(481, 19);
            this.recipeFinderLabel.Name = "recipeFinderLabel";
            this.recipeFinderLabel.Size = new System.Drawing.Size(395, 63);
            this.recipeFinderLabel.TabIndex = 0;
            this.recipeFinderLabel.Text = "Recipe Finder";
            // 
            // recipeDataGridView
            // 
            this.recipeDataGridView.BackgroundColor = System.Drawing.Color.Bisque;
            this.recipeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeDataGridView.Location = new System.Drawing.Point(709, 106);
            this.recipeDataGridView.Name = "recipeDataGridView";
            this.recipeDataGridView.Size = new System.Drawing.Size(610, 783);
            this.recipeDataGridView.TabIndex = 1;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.Sienna;
            this.questionLabel.Location = new System.Drawing.Point(55, 146);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(441, 41);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "What\'s in your kitchen?";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox1.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(62, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(466, 34);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "write ingredient here";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // specificationLabel
            // 
            this.specificationLabel.AutoSize = true;
            this.specificationLabel.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specificationLabel.ForeColor = System.Drawing.Color.Sienna;
            this.specificationLabel.Location = new System.Drawing.Point(66, 315);
            this.specificationLabel.Name = "specificationLabel";
            this.specificationLabel.Size = new System.Drawing.Size(486, 41);
            this.specificationLabel.TabIndex = 4;
            this.specificationLabel.Text = "Choose your specifications";
            // 
            // vegetarianCheckBox
            // 
            this.vegetarianCheckBox.AutoSize = true;
            this.vegetarianCheckBox.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vegetarianCheckBox.ForeColor = System.Drawing.Color.Sienna;
            this.vegetarianCheckBox.Location = new System.Drawing.Point(184, 673);
            this.vegetarianCheckBox.Name = "vegetarianCheckBox";
            this.vegetarianCheckBox.Size = new System.Drawing.Size(206, 40);
            this.vegetarianCheckBox.TabIndex = 5;
            this.vegetarianCheckBox.Text = "Vegetarian";
            this.vegetarianCheckBox.UseVisualStyleBackColor = true;
            // 
            // cookingTimeComboBox
            // 
            this.cookingTimeComboBox.FormattingEnabled = true;
            this.cookingTimeComboBox.Location = new System.Drawing.Point(155, 443);
            this.cookingTimeComboBox.Name = "cookingTimeComboBox";
            this.cookingTimeComboBox.Size = new System.Drawing.Size(269, 35);
            this.cookingTimeComboBox.TabIndex = 6;
            // 
            // cookingTimelLabel
            // 
            this.cookingTimelLabel.AutoSize = true;
            this.cookingTimelLabel.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cookingTimelLabel.ForeColor = System.Drawing.Color.Sienna;
            this.cookingTimelLabel.Location = new System.Drawing.Point(148, 381);
            this.cookingTimelLabel.Name = "cookingTimelLabel";
            this.cookingTimelLabel.Size = new System.Drawing.Size(266, 41);
            this.cookingTimelLabel.TabIndex = 7;
            this.cookingTimelLabel.Text = "Cooking Time";
            // 
            // prepTimeLabel
            // 
            this.prepTimeLabel.AutoSize = true;
            this.prepTimeLabel.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepTimeLabel.ForeColor = System.Drawing.Color.Sienna;
            this.prepTimeLabel.Location = new System.Drawing.Point(123, 519);
            this.prepTimeLabel.Name = "prepTimeLabel";
            this.prepTimeLabel.Size = new System.Drawing.Size(337, 41);
            this.prepTimeLabel.TabIndex = 8;
            this.prepTimeLabel.Text = "Preparation Time";
            this.prepTimeLabel.Click += new System.EventHandler(this.prepTimeLabel_Click);
            // 
            // prepTimeComboBox
            // 
            this.prepTimeComboBox.FormattingEnabled = true;
            this.prepTimeComboBox.Location = new System.Drawing.Point(155, 592);
            this.prepTimeComboBox.Name = "prepTimeComboBox";
            this.prepTimeComboBox.Size = new System.Drawing.Size(269, 35);
            this.prepTimeComboBox.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Chocolate;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.searchButton.ForeColor = System.Drawing.Color.Snow;
            this.searchButton.Location = new System.Drawing.Point(184, 773);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(220, 72);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // RecipeFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1385, 935);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.prepTimeComboBox);
            this.Controls.Add(this.prepTimeLabel);
            this.Controls.Add(this.cookingTimelLabel);
            this.Controls.Add(this.cookingTimeComboBox);
            this.Controls.Add(this.vegetarianCheckBox);
            this.Controls.Add(this.specificationLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.recipeDataGridView);
            this.Controls.Add(this.recipeFinderLabel);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "RecipeFinder";
            this.Text = "Recipe Finder";
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recipeFinderLabel;
        private System.Windows.Forms.DataGridView recipeDataGridView;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label specificationLabel;
        private System.Windows.Forms.CheckBox vegetarianCheckBox;
        private System.Windows.Forms.ComboBox cookingTimeComboBox;
        private System.Windows.Forms.Label cookingTimelLabel;
        private System.Windows.Forms.Label prepTimeLabel;
        private System.Windows.Forms.ComboBox prepTimeComboBox;
        private System.Windows.Forms.Button searchButton;
    }
}

