﻿namespace SalesParamsApprove
{
    partial class fmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.gcSKU = new DevExpress.XtraGrid.GridControl();
            this.gvSKU = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnIdSKU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNTov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.textBoxCurRemain = new System.Windows.Forms.TextBox();
            this.textBoxCurDays = new System.Windows.Forms.TextBox();
            this.textBoxTargetDays = new System.Windows.Forms.TextBox();
            this.textBoxPeriodAnal = new System.Windows.Forms.TextBox();
            this.textBoxCurTemp = new System.Windows.Forms.TextBox();
            this.textBoxHO = new System.Windows.Forms.TextBox();
            this.textBoxSaleDays = new System.Windows.Forms.TextBox();
            this.textBoxStepSale = new System.Windows.Forms.TextBox();
            this.textBoxRequireTemp = new System.Windows.Forms.TextBox();
            this.textBoxMCSales = new System.Windows.Forms.TextBox();
            this.textBoxDiscountMC = new System.Windows.Forms.TextBox();
            this.textBoxMCMarket = new System.Windows.Forms.TextBox();
            this.textBoxPeriodAlertRTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBoxAR = new System.Windows.Forms.CheckBox();
            this.checkBoxIP = new System.Windows.Forms.CheckBox();
            this.checkBoxOPT = new System.Windows.Forms.CheckBox();
            this.checkBoxA1 = new System.Windows.Forms.CheckBox();
            this.checkBoxSpec = new System.Windows.Forms.CheckBox();
            this.checkBoxKP = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.BtnRefreshData = new DevExpress.XtraEditors.SimpleButton();
            this.btnApprove = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveData = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcSKU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSKU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSKU
            // 
            this.gcSKU.Location = new System.Drawing.Point(12, 60);
            this.gcSKU.MainView = this.gvSKU;
            this.gcSKU.Name = "gcSKU";
            this.gcSKU.Size = new System.Drawing.Size(921, 538);
            this.gcSKU.TabIndex = 0;
            this.gcSKU.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSKU});
            // 
            // gvSKU
            // 
            this.gvSKU.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.gvSKU.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSKU.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.gvSKU.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvSKU.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.gvSKU.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvSKU.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnIdSKU,
            this.gridColumnArt,
            this.gridColumnBrand,
            this.gridColumnNTov,
            this.gridColumnStatus,
            this.gridColumn1});
            this.gvSKU.GridControl = this.gcSKU;
            this.gvSKU.Name = "gvSKU";
            this.gvSKU.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvSKU_FocusedRowChanged);
            // 
            // gridColumnIdSKU
            // 
            this.gridColumnIdSKU.AppearanceCell.Font = new System.Drawing.Font("Arial", 10F);
            this.gridColumnIdSKU.AppearanceCell.Options.UseFont = true;
            this.gridColumnIdSKU.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10F);
            this.gridColumnIdSKU.AppearanceHeader.Options.UseFont = true;
            this.gridColumnIdSKU.Caption = "gridColumn1";
            this.gridColumnIdSKU.FieldName = "idSKU";
            this.gridColumnIdSKU.Name = "gridColumnIdSKU";
            this.gridColumnIdSKU.Visible = true;
            this.gridColumnIdSKU.VisibleIndex = 4;
            this.gridColumnIdSKU.Width = 81;
            // 
            // gridColumnArt
            // 
            this.gridColumnArt.AppearanceCell.Font = new System.Drawing.Font("Arial", 10F);
            this.gridColumnArt.AppearanceCell.Options.UseFont = true;
            this.gridColumnArt.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumnArt.AppearanceHeader.Options.UseFont = true;
            this.gridColumnArt.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnArt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnArt.Caption = "Артикул";
            this.gridColumnArt.FieldName = "Art";
            this.gridColumnArt.Name = "gridColumnArt";
            this.gridColumnArt.OptionsColumn.AllowEdit = false;
            this.gridColumnArt.Visible = true;
            this.gridColumnArt.VisibleIndex = 0;
            this.gridColumnArt.Width = 151;
            // 
            // gridColumnBrand
            // 
            this.gridColumnBrand.AppearanceCell.Font = new System.Drawing.Font("Arial", 10F);
            this.gridColumnBrand.AppearanceCell.Options.UseFont = true;
            this.gridColumnBrand.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumnBrand.AppearanceHeader.Options.UseFont = true;
            this.gridColumnBrand.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnBrand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnBrand.Caption = "Бренд";
            this.gridColumnBrand.FieldName = "Brand";
            this.gridColumnBrand.Name = "gridColumnBrand";
            this.gridColumnBrand.OptionsColumn.AllowEdit = false;
            this.gridColumnBrand.Visible = true;
            this.gridColumnBrand.VisibleIndex = 1;
            this.gridColumnBrand.Width = 157;
            // 
            // gridColumnNTov
            // 
            this.gridColumnNTov.AppearanceCell.Font = new System.Drawing.Font("Arial", 10F);
            this.gridColumnNTov.AppearanceCell.Options.UseFont = true;
            this.gridColumnNTov.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumnNTov.AppearanceHeader.Options.UseFont = true;
            this.gridColumnNTov.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnNTov.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNTov.Caption = "Наименование";
            this.gridColumnNTov.FieldName = "Ntov";
            this.gridColumnNTov.Name = "gridColumnNTov";
            this.gridColumnNTov.OptionsColumn.AllowEdit = false;
            this.gridColumnNTov.Visible = true;
            this.gridColumnNTov.VisibleIndex = 2;
            this.gridColumnNTov.Width = 380;
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.AppearanceCell.Font = new System.Drawing.Font("Arial", 10F);
            this.gridColumnStatus.AppearanceCell.Options.UseFont = true;
            this.gridColumnStatus.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumnStatus.AppearanceHeader.Options.UseFont = true;
            this.gridColumnStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnStatus.Caption = "Статус распродажи";
            this.gridColumnStatus.FieldName = "SaleStatus";
            this.gridColumnStatus.Name = "gridColumnStatus";
            this.gridColumnStatus.OptionsColumn.AllowEdit = false;
            this.gridColumnStatus.Visible = true;
            this.gridColumnStatus.VisibleIndex = 3;
            this.gridColumnStatus.Width = 179;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "idStatus";
            this.gridColumn1.FieldName = "idStatus";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gcSKU;
            this.searchControl1.Location = new System.Drawing.Point(12, 28);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.AutoHeight = false;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gcSKU;
            this.searchControl1.Size = new System.Drawing.Size(268, 26);
            this.searchControl1.TabIndex = 1;
            // 
            // textBoxCurRemain
            // 
            this.textBoxCurRemain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textBoxCurRemain.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCurRemain.Location = new System.Drawing.Point(1114, 132);
            this.textBoxCurRemain.Name = "textBoxCurRemain";
            this.textBoxCurRemain.ReadOnly = true;
            this.textBoxCurRemain.Size = new System.Drawing.Size(100, 26);
            this.textBoxCurRemain.TabIndex = 2;
            this.textBoxCurRemain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCurDays
            // 
            this.textBoxCurDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textBoxCurDays.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCurDays.Location = new System.Drawing.Point(1114, 171);
            this.textBoxCurDays.Name = "textBoxCurDays";
            this.textBoxCurDays.ReadOnly = true;
            this.textBoxCurDays.Size = new System.Drawing.Size(100, 26);
            this.textBoxCurDays.TabIndex = 3;
            this.textBoxCurDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTargetDays
            // 
            this.textBoxTargetDays.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxTargetDays.Location = new System.Drawing.Point(1114, 214);
            this.textBoxTargetDays.Name = "textBoxTargetDays";
            this.textBoxTargetDays.Size = new System.Drawing.Size(100, 26);
            this.textBoxTargetDays.TabIndex = 4;
            this.textBoxTargetDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPeriodAnal
            // 
            this.textBoxPeriodAnal.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxPeriodAnal.Location = new System.Drawing.Point(1114, 255);
            this.textBoxPeriodAnal.Name = "textBoxPeriodAnal";
            this.textBoxPeriodAnal.Size = new System.Drawing.Size(100, 26);
            this.textBoxPeriodAnal.TabIndex = 5;
            this.textBoxPeriodAnal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCurTemp
            // 
            this.textBoxCurTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textBoxCurTemp.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCurTemp.Location = new System.Drawing.Point(1449, 132);
            this.textBoxCurTemp.Name = "textBoxCurTemp";
            this.textBoxCurTemp.ReadOnly = true;
            this.textBoxCurTemp.Size = new System.Drawing.Size(100, 26);
            this.textBoxCurTemp.TabIndex = 6;
            this.textBoxCurTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHO
            // 
            this.textBoxHO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textBoxHO.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHO.Location = new System.Drawing.Point(1449, 171);
            this.textBoxHO.Name = "textBoxHO";
            this.textBoxHO.ReadOnly = true;
            this.textBoxHO.Size = new System.Drawing.Size(100, 26);
            this.textBoxHO.TabIndex = 7;
            this.textBoxHO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSaleDays
            // 
            this.textBoxSaleDays.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxSaleDays.Location = new System.Drawing.Point(1449, 214);
            this.textBoxSaleDays.Name = "textBoxSaleDays";
            this.textBoxSaleDays.Size = new System.Drawing.Size(100, 26);
            this.textBoxSaleDays.TabIndex = 8;
            this.textBoxSaleDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStepSale
            // 
            this.textBoxStepSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textBoxStepSale.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStepSale.Location = new System.Drawing.Point(1449, 255);
            this.textBoxStepSale.Name = "textBoxStepSale";
            this.textBoxStepSale.ReadOnly = true;
            this.textBoxStepSale.Size = new System.Drawing.Size(100, 26);
            this.textBoxStepSale.TabIndex = 9;
            this.textBoxStepSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRequireTemp
            // 
            this.textBoxRequireTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textBoxRequireTemp.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRequireTemp.Location = new System.Drawing.Point(1692, 132);
            this.textBoxRequireTemp.Name = "textBoxRequireTemp";
            this.textBoxRequireTemp.ReadOnly = true;
            this.textBoxRequireTemp.Size = new System.Drawing.Size(100, 26);
            this.textBoxRequireTemp.TabIndex = 10;
            this.textBoxRequireTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMCSales
            // 
            this.textBoxMCSales.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMCSales.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxMCSales.Location = new System.Drawing.Point(1692, 192);
            this.textBoxMCSales.Name = "textBoxMCSales";
            this.textBoxMCSales.Size = new System.Drawing.Size(100, 26);
            this.textBoxMCSales.TabIndex = 11;
            this.textBoxMCSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDiscountMC
            // 
            this.textBoxDiscountMC.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxDiscountMC.Location = new System.Drawing.Point(1692, 257);
            this.textBoxDiscountMC.Name = "textBoxDiscountMC";
            this.textBoxDiscountMC.Size = new System.Drawing.Size(100, 26);
            this.textBoxDiscountMC.TabIndex = 12;
            this.textBoxDiscountMC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMCMarket
            // 
            this.textBoxMCMarket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textBoxMCMarket.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMCMarket.Location = new System.Drawing.Point(1692, 311);
            this.textBoxMCMarket.Name = "textBoxMCMarket";
            this.textBoxMCMarket.ReadOnly = true;
            this.textBoxMCMarket.Size = new System.Drawing.Size(100, 26);
            this.textBoxMCMarket.TabIndex = 13;
            this.textBoxMCMarket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPeriodAlertRTK
            // 
            this.textBoxPeriodAlertRTK.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxPeriodAlertRTK.Location = new System.Drawing.Point(1692, 375);
            this.textBoxPeriodAlertRTK.Name = "textBoxPeriodAlertRTK";
            this.textBoxPeriodAlertRTK.Size = new System.Drawing.Size(100, 26);
            this.textBoxPeriodAlertRTK.TabIndex = 14;
            this.textBoxPeriodAlertRTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(971, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Текущий остаток, шт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(958, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Текущий остаток, дней";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(971, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Целевой остаток, шт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(961, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Период анализа, дней";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(1250, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Текущий темп продаж, шт/д";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(1363, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "НО, дней";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.Location = new System.Drawing.Point(1276, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Срок распродажи, дней";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.Location = new System.Drawing.Point(1290, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Шаг распродажи, руб";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label9.Location = new System.Drawing.Point(1577, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 34);
            this.label9.TabIndex = 23;
            this.label9.Text = "Требуемый темп продаж, шт/д";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label10.Location = new System.Drawing.Point(1577, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 53);
            this.label10.TabIndex = 24;
            this.label10.Text = "МЦ Распродажи, % от УЦ 41";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label11.Location = new System.Drawing.Point(1577, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 34);
            this.label11.TabIndex = 25;
            this.label11.Text = "Скидка от МЦ рынка, %";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label12.Location = new System.Drawing.Point(1577, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "МЦ рынка, руб";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label13.Location = new System.Drawing.Point(1577, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 58);
            this.label13.TabIndex = 27;
            this.label13.Text = "Период оповещения РТК, дней";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label14.Location = new System.Drawing.Point(990, 321);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Каналы сбыта";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label15.Location = new System.Drawing.Point(990, 358);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "АР";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label16.Location = new System.Drawing.Point(990, 387);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 16);
            this.label16.TabIndex = 30;
            this.label16.Text = "ИП";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label17.Location = new System.Drawing.Point(988, 418);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 16);
            this.label17.TabIndex = 31;
            this.label17.Text = "ОПТ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label18.Location = new System.Drawing.Point(988, 450);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 16);
            this.label18.TabIndex = 32;
            this.label18.Text = "А1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label19.Location = new System.Drawing.Point(988, 484);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 16);
            this.label19.TabIndex = 33;
            this.label19.Text = "Спец Экзист";
            // 
            // checkBoxAR
            // 
            this.checkBoxAR.AutoSize = true;
            this.checkBoxAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAR.Location = new System.Drawing.Point(1143, 356);
            this.checkBoxAR.Name = "checkBoxAR";
            this.checkBoxAR.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAR.TabIndex = 34;
            this.checkBoxAR.UseVisualStyleBackColor = true;
            // 
            // checkBoxIP
            // 
            this.checkBoxIP.AutoSize = true;
            this.checkBoxIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIP.Location = new System.Drawing.Point(1143, 387);
            this.checkBoxIP.Name = "checkBoxIP";
            this.checkBoxIP.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIP.TabIndex = 35;
            this.checkBoxIP.UseVisualStyleBackColor = true;
            // 
            // checkBoxOPT
            // 
            this.checkBoxOPT.AutoSize = true;
            this.checkBoxOPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxOPT.Location = new System.Drawing.Point(1143, 418);
            this.checkBoxOPT.Name = "checkBoxOPT";
            this.checkBoxOPT.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOPT.TabIndex = 36;
            this.checkBoxOPT.UseVisualStyleBackColor = true;
            // 
            // checkBoxA1
            // 
            this.checkBoxA1.AutoSize = true;
            this.checkBoxA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxA1.Location = new System.Drawing.Point(1143, 448);
            this.checkBoxA1.Name = "checkBoxA1";
            this.checkBoxA1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxA1.TabIndex = 37;
            this.checkBoxA1.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpec
            // 
            this.checkBoxSpec.AutoSize = true;
            this.checkBoxSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSpec.Location = new System.Drawing.Point(1143, 484);
            this.checkBoxSpec.Name = "checkBoxSpec";
            this.checkBoxSpec.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSpec.TabIndex = 38;
            this.checkBoxSpec.UseVisualStyleBackColor = true;
            // 
            // checkBoxKP
            // 
            this.checkBoxKP.AutoSize = true;
            this.checkBoxKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxKP.Location = new System.Drawing.Point(1143, 517);
            this.checkBoxKP.Name = "checkBoxKP";
            this.checkBoxKP.Size = new System.Drawing.Size(15, 14);
            this.checkBoxKP.TabIndex = 41;
            this.checkBoxKP.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label20.Location = new System.Drawing.Point(988, 517);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 16);
            this.label20.TabIndex = 40;
            this.label20.Text = "КП";
            // 
            // BtnRefreshData
            // 
            this.BtnRefreshData.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefreshData.ImageOptions.Image")));
            this.BtnRefreshData.Location = new System.Drawing.Point(891, 21);
            this.BtnRefreshData.Name = "BtnRefreshData";
            this.BtnRefreshData.Size = new System.Drawing.Size(42, 37);
            this.BtnRefreshData.TabIndex = 45;
            this.BtnRefreshData.ToolTip = "Обновить все данные";
            this.BtnRefreshData.Click += new System.EventHandler(this.BtnRefreshData_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnApprove.Appearance.BackColor2 = System.Drawing.Color.LightGray;
            this.btnApprove.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnApprove.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApprove.Appearance.Options.UseBackColor = true;
            this.btnApprove.Appearance.Options.UseBorderColor = true;
            this.btnApprove.Appearance.Options.UseFont = true;
            this.btnApprove.AppearanceDisabled.BackColor = System.Drawing.Color.LightGray;
            this.btnApprove.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnApprove.AppearanceDisabled.Options.UseBackColor = true;
            this.btnApprove.AppearanceDisabled.Options.UseFont = true;
            this.btnApprove.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.btnApprove.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnApprove.AppearanceHovered.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnApprove.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnApprove.AppearanceHovered.Options.UseBackColor = true;
            this.btnApprove.AppearanceHovered.Options.UseFont = true;
            this.btnApprove.AppearancePressed.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnApprove.AppearancePressed.Options.UseFont = true;
            this.btnApprove.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnApprove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnApprove.ImageOptions.Image")));
            this.btnApprove.Location = new System.Drawing.Point(1692, 12);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(145, 35);
            this.btnApprove.TabIndex = 46;
            this.btnApprove.Text = "Согласовать";
            this.btnApprove.ToolTip = "Согласовать параметры распродажи";
            this.btnApprove.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveData.Appearance.BackColor2 = System.Drawing.Color.LightGray;
            this.btnSaveData.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnSaveData.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveData.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnSaveData.Appearance.Options.UseBackColor = true;
            this.btnSaveData.Appearance.Options.UseBorderColor = true;
            this.btnSaveData.Appearance.Options.UseFont = true;
            this.btnSaveData.AppearanceDisabled.BackColor = System.Drawing.Color.LightGray;
            this.btnSaveData.AppearanceDisabled.Options.UseBackColor = true;
            this.btnSaveData.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveData.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnSaveData.AppearanceHovered.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveData.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnSaveData.AppearanceHovered.Options.UseBackColor = true;
            this.btnSaveData.AppearanceHovered.Options.UseFont = true;
            this.btnSaveData.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSaveData.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveData.ImageOptions.Image")));
            this.btnSaveData.Location = new System.Drawing.Point(1692, 54);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(145, 35);
            this.btnSaveData.TabIndex = 47;
            this.btnSaveData.Text = "Сохранить";
            this.btnSaveData.ToolTip = "Сохранить параметры распродажи";
            this.btnSaveData.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 610);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.BtnRefreshData);
            this.Controls.Add(this.checkBoxKP);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.checkBoxSpec);
            this.Controls.Add(this.checkBoxA1);
            this.Controls.Add(this.checkBoxOPT);
            this.Controls.Add(this.checkBoxIP);
            this.Controls.Add(this.checkBoxAR);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPeriodAlertRTK);
            this.Controls.Add(this.textBoxMCMarket);
            this.Controls.Add(this.textBoxDiscountMC);
            this.Controls.Add(this.textBoxMCSales);
            this.Controls.Add(this.textBoxRequireTemp);
            this.Controls.Add(this.textBoxStepSale);
            this.Controls.Add(this.textBoxSaleDays);
            this.Controls.Add(this.textBoxHO);
            this.Controls.Add(this.textBoxCurTemp);
            this.Controls.Add(this.textBoxPeriodAnal);
            this.Controls.Add(this.textBoxTargetDays);
            this.Controls.Add(this.textBoxCurDays);
            this.Controls.Add(this.textBoxCurRemain);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.gcSKU);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Распродажа настройки";
            this.Load += new System.EventHandler(this.fmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcSKU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSKU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSKU;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSKU;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIdSKU;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnArt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBrand;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNTov;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.TextBox textBoxCurRemain;
        private System.Windows.Forms.TextBox textBoxCurDays;
        private System.Windows.Forms.TextBox textBoxTargetDays;
        private System.Windows.Forms.TextBox textBoxPeriodAnal;
        private System.Windows.Forms.TextBox textBoxCurTemp;
        private System.Windows.Forms.TextBox textBoxHO;
        private System.Windows.Forms.TextBox textBoxSaleDays;
        private System.Windows.Forms.TextBox textBoxStepSale;
        private System.Windows.Forms.TextBox textBoxRequireTemp;
        private System.Windows.Forms.TextBox textBoxMCSales;
        private System.Windows.Forms.TextBox textBoxDiscountMC;
        private System.Windows.Forms.TextBox textBoxMCMarket;
        private System.Windows.Forms.TextBox textBoxPeriodAlertRTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox checkBoxAR;
        private System.Windows.Forms.CheckBox checkBoxIP;
        private System.Windows.Forms.CheckBox checkBoxOPT;
        private System.Windows.Forms.CheckBox checkBoxA1;
        private System.Windows.Forms.CheckBox checkBoxSpec;
        private System.Windows.Forms.CheckBox checkBoxKP;
        private System.Windows.Forms.Label label20;
        private DevExpress.XtraEditors.SimpleButton BtnRefreshData;
        private DevExpress.XtraEditors.SimpleButton btnApprove;
        private DevExpress.XtraEditors.SimpleButton btnSaveData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}

