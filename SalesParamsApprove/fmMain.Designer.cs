namespace SalesParamsApprove
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
            this.teCurRemain = new DevExpress.XtraEditors.TextEdit();
            this.teTargetRemain = new DevExpress.XtraEditors.TextEdit();
            this.teCurDays = new DevExpress.XtraEditors.TextEdit();
            this.tePeriodAnal = new DevExpress.XtraEditors.TextEdit();
            this.teCurTemp = new DevExpress.XtraEditors.TextEdit();
            this.teHO = new DevExpress.XtraEditors.TextEdit();
            this.teSaleDays = new DevExpress.XtraEditors.TextEdit();
            this.teStepSale = new DevExpress.XtraEditors.TextEdit();
            this.teRequireTemp = new DevExpress.XtraEditors.TextEdit();
            this.teMCSales = new DevExpress.XtraEditors.TextEdit();
            this.teDiscountMC = new DevExpress.XtraEditors.TextEdit();
            this.teMCMarket = new DevExpress.XtraEditors.TextEdit();
            this.tePeriodAlertRTK = new DevExpress.XtraEditors.TextEdit();
            this.teCurPriceSale = new DevExpress.XtraEditors.TextEdit();
            this.labelCurPriceSale = new System.Windows.Forms.Label();
            this.labelDateSale = new System.Windows.Forms.Label();
            this.teDate = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSKU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSKU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCurRemain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTargetRemain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCurDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePeriodAnal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCurTemp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSaleDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teStepSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRequireTemp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMCSales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDiscountMC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMCMarket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePeriodAlertRTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCurPriceSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDate.Properties)).BeginInit();
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
            this.gridColumnIdSKU.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnIdSKU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumnIdSKU.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumnIdSKU.AppearanceHeader.Options.UseFont = true;
            this.gridColumnIdSKU.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnIdSKU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnIdSKU.Caption = "Код товара";
            this.gridColumnIdSKU.FieldName = "idSKU";
            this.gridColumnIdSKU.Name = "gridColumnIdSKU";
            this.gridColumnIdSKU.OptionsColumn.ReadOnly = true;
            this.gridColumnIdSKU.Visible = true;
            this.gridColumnIdSKU.VisibleIndex = 0;
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
            this.gridColumnArt.VisibleIndex = 1;
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
            this.gridColumnBrand.VisibleIndex = 2;
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
            this.gridColumnNTov.VisibleIndex = 3;
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
            this.gridColumnStatus.VisibleIndex = 4;
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
            this.label4.Location = new System.Drawing.Point(1528, 400);
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
            this.label7.Location = new System.Drawing.Point(1519, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Срок распродажи, дней";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.Location = new System.Drawing.Point(1290, 218);
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
            this.label12.Location = new System.Drawing.Point(1572, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "МЦ рынка, руб";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label13.Location = new System.Drawing.Point(1561, 440);
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
            this.checkBoxKP.Visible = false;
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
            this.label20.Visible = false;
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
            this.btnApprove.Enabled = false;
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
            this.btnSaveData.Enabled = false;
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
            // teCurRemain
            // 
            this.teCurRemain.Location = new System.Drawing.Point(1114, 133);
            this.teCurRemain.Name = "teCurRemain";
            this.teCurRemain.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.teCurRemain.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teCurRemain.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teCurRemain.Properties.Appearance.Options.UseBackColor = true;
            this.teCurRemain.Properties.Appearance.Options.UseBorderColor = true;
            this.teCurRemain.Properties.Appearance.Options.UseFont = true;
            this.teCurRemain.Properties.Appearance.Options.UseTextOptions = true;
            this.teCurRemain.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teCurRemain.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teCurRemain.Properties.ReadOnly = true;
            this.teCurRemain.Size = new System.Drawing.Size(100, 22);
            this.teCurRemain.TabIndex = 48;
            // 
            // teTargetRemain
            // 
            this.teTargetRemain.Location = new System.Drawing.Point(1114, 215);
            this.teTargetRemain.Name = "teTargetRemain";
            this.teTargetRemain.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teTargetRemain.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teTargetRemain.Properties.Appearance.Options.UseBorderColor = true;
            this.teTargetRemain.Properties.Appearance.Options.UseFont = true;
            this.teTargetRemain.Properties.Appearance.Options.UseTextOptions = true;
            this.teTargetRemain.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teTargetRemain.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teTargetRemain.Size = new System.Drawing.Size(100, 22);
            this.teTargetRemain.TabIndex = 49;
            // 
            // teCurDays
            // 
            this.teCurDays.Location = new System.Drawing.Point(1114, 173);
            this.teCurDays.Name = "teCurDays";
            this.teCurDays.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.teCurDays.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teCurDays.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teCurDays.Properties.Appearance.Options.UseBackColor = true;
            this.teCurDays.Properties.Appearance.Options.UseBorderColor = true;
            this.teCurDays.Properties.Appearance.Options.UseFont = true;
            this.teCurDays.Properties.Appearance.Options.UseTextOptions = true;
            this.teCurDays.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teCurDays.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teCurDays.Properties.ReadOnly = true;
            this.teCurDays.Size = new System.Drawing.Size(100, 22);
            this.teCurDays.TabIndex = 50;
            // 
            // tePeriodAnal
            // 
            this.tePeriodAnal.Location = new System.Drawing.Point(1692, 397);
            this.tePeriodAnal.Name = "tePeriodAnal";
            this.tePeriodAnal.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tePeriodAnal.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tePeriodAnal.Properties.Appearance.Options.UseBorderColor = true;
            this.tePeriodAnal.Properties.Appearance.Options.UseFont = true;
            this.tePeriodAnal.Properties.Appearance.Options.UseTextOptions = true;
            this.tePeriodAnal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tePeriodAnal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tePeriodAnal.Size = new System.Drawing.Size(100, 22);
            this.tePeriodAnal.TabIndex = 51;
            // 
            // teCurTemp
            // 
            this.teCurTemp.Location = new System.Drawing.Point(1449, 132);
            this.teCurTemp.Name = "teCurTemp";
            this.teCurTemp.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.teCurTemp.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teCurTemp.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teCurTemp.Properties.Appearance.Options.UseBackColor = true;
            this.teCurTemp.Properties.Appearance.Options.UseBorderColor = true;
            this.teCurTemp.Properties.Appearance.Options.UseFont = true;
            this.teCurTemp.Properties.Appearance.Options.UseTextOptions = true;
            this.teCurTemp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teCurTemp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teCurTemp.Properties.ReadOnly = true;
            this.teCurTemp.Size = new System.Drawing.Size(100, 22);
            this.teCurTemp.TabIndex = 52;
            // 
            // teHO
            // 
            this.teHO.Location = new System.Drawing.Point(1449, 173);
            this.teHO.Name = "teHO";
            this.teHO.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.teHO.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teHO.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teHO.Properties.Appearance.Options.UseBackColor = true;
            this.teHO.Properties.Appearance.Options.UseBorderColor = true;
            this.teHO.Properties.Appearance.Options.UseFont = true;
            this.teHO.Properties.Appearance.Options.UseTextOptions = true;
            this.teHO.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teHO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teHO.Properties.ReadOnly = true;
            this.teHO.Size = new System.Drawing.Size(100, 22);
            this.teHO.TabIndex = 53;
            // 
            // teSaleDays
            // 
            this.teSaleDays.Location = new System.Drawing.Point(1692, 355);
            this.teSaleDays.Name = "teSaleDays";
            this.teSaleDays.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teSaleDays.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teSaleDays.Properties.Appearance.Options.UseBorderColor = true;
            this.teSaleDays.Properties.Appearance.Options.UseFont = true;
            this.teSaleDays.Properties.Appearance.Options.UseTextOptions = true;
            this.teSaleDays.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teSaleDays.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teSaleDays.Size = new System.Drawing.Size(100, 22);
            this.teSaleDays.TabIndex = 54;
            // 
            // teStepSale
            // 
            this.teStepSale.Location = new System.Drawing.Point(1449, 215);
            this.teStepSale.Name = "teStepSale";
            this.teStepSale.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.teStepSale.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teStepSale.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teStepSale.Properties.Appearance.Options.UseBackColor = true;
            this.teStepSale.Properties.Appearance.Options.UseBorderColor = true;
            this.teStepSale.Properties.Appearance.Options.UseFont = true;
            this.teStepSale.Properties.Appearance.Options.UseTextOptions = true;
            this.teStepSale.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teStepSale.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teStepSale.Properties.ReadOnly = true;
            this.teStepSale.Size = new System.Drawing.Size(100, 22);
            this.teStepSale.TabIndex = 55;
            // 
            // teRequireTemp
            // 
            this.teRequireTemp.Location = new System.Drawing.Point(1692, 133);
            this.teRequireTemp.Name = "teRequireTemp";
            this.teRequireTemp.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.teRequireTemp.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teRequireTemp.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teRequireTemp.Properties.Appearance.Options.UseBackColor = true;
            this.teRequireTemp.Properties.Appearance.Options.UseBorderColor = true;
            this.teRequireTemp.Properties.Appearance.Options.UseFont = true;
            this.teRequireTemp.Properties.Appearance.Options.UseTextOptions = true;
            this.teRequireTemp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teRequireTemp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teRequireTemp.Properties.ReadOnly = true;
            this.teRequireTemp.Size = new System.Drawing.Size(100, 22);
            this.teRequireTemp.TabIndex = 56;
            // 
            // teMCSales
            // 
            this.teMCSales.Location = new System.Drawing.Point(1692, 199);
            this.teMCSales.Name = "teMCSales";
            this.teMCSales.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teMCSales.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teMCSales.Properties.Appearance.Options.UseBorderColor = true;
            this.teMCSales.Properties.Appearance.Options.UseFont = true;
            this.teMCSales.Properties.Appearance.Options.UseTextOptions = true;
            this.teMCSales.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teMCSales.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teMCSales.Size = new System.Drawing.Size(100, 22);
            this.teMCSales.TabIndex = 57;
            // 
            // teDiscountMC
            // 
            this.teDiscountMC.Location = new System.Drawing.Point(1692, 258);
            this.teDiscountMC.Name = "teDiscountMC";
            this.teDiscountMC.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teDiscountMC.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teDiscountMC.Properties.Appearance.Options.UseBorderColor = true;
            this.teDiscountMC.Properties.Appearance.Options.UseFont = true;
            this.teDiscountMC.Properties.Appearance.Options.UseTextOptions = true;
            this.teDiscountMC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teDiscountMC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teDiscountMC.Size = new System.Drawing.Size(100, 22);
            this.teDiscountMC.TabIndex = 58;
            // 
            // teMCMarket
            // 
            this.teMCMarket.Location = new System.Drawing.Point(1692, 312);
            this.teMCMarket.Name = "teMCMarket";
            this.teMCMarket.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.teMCMarket.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teMCMarket.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teMCMarket.Properties.Appearance.Options.UseBackColor = true;
            this.teMCMarket.Properties.Appearance.Options.UseBorderColor = true;
            this.teMCMarket.Properties.Appearance.Options.UseFont = true;
            this.teMCMarket.Properties.Appearance.Options.UseTextOptions = true;
            this.teMCMarket.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teMCMarket.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teMCMarket.Properties.ReadOnly = true;
            this.teMCMarket.Size = new System.Drawing.Size(100, 22);
            this.teMCMarket.TabIndex = 59;
            // 
            // tePeriodAlertRTK
            // 
            this.tePeriodAlertRTK.Location = new System.Drawing.Point(1692, 447);
            this.tePeriodAlertRTK.Name = "tePeriodAlertRTK";
            this.tePeriodAlertRTK.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tePeriodAlertRTK.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tePeriodAlertRTK.Properties.Appearance.Options.UseBorderColor = true;
            this.tePeriodAlertRTK.Properties.Appearance.Options.UseFont = true;
            this.tePeriodAlertRTK.Properties.Appearance.Options.UseTextOptions = true;
            this.tePeriodAlertRTK.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tePeriodAlertRTK.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tePeriodAlertRTK.Size = new System.Drawing.Size(100, 22);
            this.tePeriodAlertRTK.TabIndex = 60;
            // 
            // teCurPriceSale
            // 
            this.teCurPriceSale.Location = new System.Drawing.Point(1165, 89);
            this.teCurPriceSale.Name = "teCurPriceSale";
            this.teCurPriceSale.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.teCurPriceSale.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teCurPriceSale.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teCurPriceSale.Properties.Appearance.Options.UseBackColor = true;
            this.teCurPriceSale.Properties.Appearance.Options.UseBorderColor = true;
            this.teCurPriceSale.Properties.Appearance.Options.UseFont = true;
            this.teCurPriceSale.Properties.Appearance.Options.UseTextOptions = true;
            this.teCurPriceSale.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teCurPriceSale.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teCurPriceSale.Properties.ReadOnly = true;
            this.teCurPriceSale.Size = new System.Drawing.Size(122, 22);
            this.teCurPriceSale.TabIndex = 62;
            this.teCurPriceSale.Visible = false;
            // 
            // labelCurPriceSale
            // 
            this.labelCurPriceSale.AutoSize = true;
            this.labelCurPriceSale.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurPriceSale.Location = new System.Drawing.Point(959, 92);
            this.labelCurPriceSale.Name = "labelCurPriceSale";
            this.labelCurPriceSale.Size = new System.Drawing.Size(198, 16);
            this.labelCurPriceSale.TabIndex = 61;
            this.labelCurPriceSale.Text = "Текущая цена распродажи, руб";
            this.labelCurPriceSale.Visible = false;
            // 
            // labelDateSale
            // 
            this.labelDateSale.AutoSize = true;
            this.labelDateSale.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateSale.Location = new System.Drawing.Point(947, 54);
            this.labelDateSale.Name = "labelDateSale";
            this.labelDateSale.Size = new System.Drawing.Size(210, 16);
            this.labelDateSale.TabIndex = 64;
            this.labelDateSale.Text = "Текущая дата старта распродажи";
            this.labelDateSale.Visible = false;
            // 
            // teDate
            // 
            this.teDate.Location = new System.Drawing.Point(1165, 51);
            this.teDate.Name = "teDate";
            this.teDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.teDate.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teDate.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teDate.Properties.Appearance.Options.UseBackColor = true;
            this.teDate.Properties.Appearance.Options.UseBorderColor = true;
            this.teDate.Properties.Appearance.Options.UseFont = true;
            this.teDate.Properties.Appearance.Options.UseTextOptions = true;
            this.teDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.teDate.Properties.ReadOnly = true;
            this.teDate.Size = new System.Drawing.Size(182, 22);
            this.teDate.TabIndex = 65;
            this.teDate.Visible = false;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 610);
            this.Controls.Add(this.teDate);
            this.Controls.Add(this.labelDateSale);
            this.Controls.Add(this.teCurPriceSale);
            this.Controls.Add(this.labelCurPriceSale);
            this.Controls.Add(this.tePeriodAlertRTK);
            this.Controls.Add(this.teMCMarket);
            this.Controls.Add(this.teDiscountMC);
            this.Controls.Add(this.teMCSales);
            this.Controls.Add(this.teRequireTemp);
            this.Controls.Add(this.teStepSale);
            this.Controls.Add(this.teSaleDays);
            this.Controls.Add(this.teHO);
            this.Controls.Add(this.teCurTemp);
            this.Controls.Add(this.tePeriodAnal);
            this.Controls.Add(this.teCurDays);
            this.Controls.Add(this.teTargetRemain);
            this.Controls.Add(this.teCurRemain);
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
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.gcSKU);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Распродажа настройки";
            this.Load += new System.EventHandler(this.fmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcSKU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSKU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCurRemain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTargetRemain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCurDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePeriodAnal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCurTemp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSaleDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teStepSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRequireTemp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMCSales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDiscountMC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMCMarket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePeriodAlertRTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCurPriceSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDate.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit teCurRemain;
        private DevExpress.XtraEditors.TextEdit teTargetRemain;
        private DevExpress.XtraEditors.TextEdit teCurDays;
        private DevExpress.XtraEditors.TextEdit tePeriodAnal;
        private DevExpress.XtraEditors.TextEdit teCurTemp;
        private DevExpress.XtraEditors.TextEdit teHO;
        private DevExpress.XtraEditors.TextEdit teSaleDays;
        private DevExpress.XtraEditors.TextEdit teStepSale;
        private DevExpress.XtraEditors.TextEdit teRequireTemp;
        private DevExpress.XtraEditors.TextEdit teMCSales;
        private DevExpress.XtraEditors.TextEdit teDiscountMC;
        private DevExpress.XtraEditors.TextEdit teMCMarket;
        private DevExpress.XtraEditors.TextEdit tePeriodAlertRTK;
        private DevExpress.XtraEditors.TextEdit teCurPriceSale;
        private System.Windows.Forms.Label labelCurPriceSale;
        private System.Windows.Forms.Label labelDateSale;
        private DevExpress.XtraEditors.TextEdit teDate;
    }
}

