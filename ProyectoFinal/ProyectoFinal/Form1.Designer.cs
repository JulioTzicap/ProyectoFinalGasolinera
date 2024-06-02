namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            btnDespacharGasolina = new Button();
            label6 = new Label();
            txtCantidadDespachar = new TextBox();
            label7 = new Label();
            txtCapacidadBomba = new TextBox();
            comboBoxElegirBomba = new ComboBox();
            label3 = new Label();
            btnElegirBomba = new Button();
            label5 = new Label();
            comboBoxEleccion = new ComboBox();
            btnIngresarCliente = new Button();
            txtNombreCliente = new TextBox();
            txtNitCliente = new TextBox();
            label4 = new Label();
            TxtApellidoCliente = new TextBox();
            tabPage2 = new TabPage();
            btnGenerarCierreDeCaja = new Button();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridViewCierreDeCaja = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Nit = new DataGridViewTextBoxColumn();
            CodigoBomba = new DataGridViewTextBoxColumn();
            CodigoTipoDeDespacho = new DataGridViewTextBoxColumn();
            FechaHora = new DataGridViewTextBoxColumn();
            PrecioDia = new DataGridViewTextBoxColumn();
            CantidadDespacho = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            btnInformeGas = new Button();
            label10 = new Label();
            comboBoxAbasteciminento = new ComboBox();
            dataGridViewInformeAbastecimiento = new DataGridView();
            NombreAbastecimiento = new DataGridViewTextBoxColumn();
            ApellidoAbastecimiento = new DataGridViewTextBoxColumn();
            NitAbastecimiento = new DataGridViewTextBoxColumn();
            BombaAbastecimiento = new DataGridViewTextBoxColumn();
            FechaHoraAbastecimiento = new DataGridViewTextBoxColumn();
            PrecioDiaAbastecimiento = new DataGridViewTextBoxColumn();
            CantidadDespachadaAbastecimiento = new DataGridViewTextBoxColumn();
            TotalAbastecimiento = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            txtBombaMasUsada = new TextBox();
            btnGenerarBombaUsada = new Button();
            comboBoxBombaUsada = new ComboBox();
            dataGridViewBombaUsada = new DataGridView();
            NombreBomba = new DataGridViewTextBoxColumn();
            ApellidoBomba = new DataGridViewTextBoxColumn();
            NitBomba = new DataGridViewTextBoxColumn();
            bombaBombaUsada = new DataGridViewTextBoxColumn();
            tipoDespachoBomba = new DataGridViewTextBoxColumn();
            fechaHoraBomba = new DataGridViewTextBoxColumn();
            precioDiaBomba = new DataGridViewTextBoxColumn();
            cantidadDespachaBomba = new DataGridViewTextBoxColumn();
            totalBomba = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCierreDeCaja).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInformeAbastecimiento).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBombaUsada).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 96);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 146);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido :";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(773, 444);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(btnDespacharGasolina);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtCantidadDespachar);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtCapacidadBomba);
            tabPage1.Controls.Add(comboBoxElegirBomba);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(btnElegirBomba);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(comboBoxEleccion);
            tabPage1.Controls.Add(btnIngresarCliente);
            tabPage1.Controls.Add(txtNombreCliente);
            tabPage1.Controls.Add(txtNitCliente);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(TxtApellidoCliente);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(765, 416);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Panel de ingreso";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(421, 58);
            label14.Name = "label14";
            label14.Size = new Size(200, 15);
            label14.TabIndex = 27;
            label14.Text = "Elegir Bomba donde se va despachar";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(41, 67);
            label13.Name = "label13";
            label13.Size = new Size(139, 15);
            label13.TabIndex = 26;
            label13.Text = "Ingresar Datos del cliente";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(318, 17);
            label12.Name = "label12";
            label12.Size = new Size(62, 15);
            label12.TabIndex = 25;
            label12.Text = "Gasolinera";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 363);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 24;
            label11.Text = "label11";
            // 
            // btnDespacharGasolina
            // 
            btnDespacharGasolina.Enabled = false;
            btnDespacharGasolina.Location = new Point(436, 315);
            btnDespacharGasolina.Name = "btnDespacharGasolina";
            btnDespacharGasolina.Size = new Size(75, 23);
            btnDespacharGasolina.TabIndex = 22;
            btnDespacharGasolina.Text = "Ingresar";
            btnDespacharGasolina.UseVisualStyleBackColor = true;
            btnDespacharGasolina.Click += btnDespacharGasolina_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 334);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 21;
            label6.Text = "Cantidad";
            // 
            // txtCantidadDespachar
            // 
            txtCantidadDespachar.Enabled = false;
            txtCantidadDespachar.Location = new Point(309, 352);
            txtCantidadDespachar.Name = "txtCantidadDespachar";
            txtCantidadDespachar.Size = new Size(92, 23);
            txtCantidadDespachar.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(499, 154);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 18;
            label7.Text = "Capacidad";
            // 
            // txtCapacidadBomba
            // 
            txtCapacidadBomba.Enabled = false;
            txtCapacidadBomba.Location = new Point(500, 172);
            txtCapacidadBomba.Name = "txtCapacidadBomba";
            txtCapacidadBomba.Size = new Size(62, 23);
            txtCapacidadBomba.TabIndex = 16;
            txtCapacidadBomba.Text = "5 litros";
            // 
            // comboBoxElegirBomba
            // 
            comboBoxElegirBomba.Enabled = false;
            comboBoxElegirBomba.FormattingEnabled = true;
            comboBoxElegirBomba.Items.AddRange(new object[] { "1", "2" });
            comboBoxElegirBomba.Location = new Point(499, 93);
            comboBoxElegirBomba.Name = "comboBoxElegirBomba";
            comboBoxElegirBomba.Size = new Size(84, 23);
            comboBoxElegirBomba.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 96);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 13;
            label3.Text = "Elegir Bomba";
            // 
            // btnElegirBomba
            // 
            btnElegirBomba.Enabled = false;
            btnElegirBomba.Location = new Point(605, 96);
            btnElegirBomba.Name = "btnElegirBomba";
            btnElegirBomba.Size = new Size(75, 23);
            btnElegirBomba.TabIndex = 12;
            btnElegirBomba.Text = "Elegir";
            btnElegirBomba.UseVisualStyleBackColor = true;
            btnElegirBomba.Click += btnElegirBomba_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 271);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 11;
            label5.Text = "Tipo de despacho";
            label5.Click += label5_Click;
            // 
            // comboBoxEleccion
            // 
            comboBoxEleccion.Enabled = false;
            comboBoxEleccion.FormattingEnabled = true;
            comboBoxEleccion.Items.AddRange(new object[] { "Tanque Lleno", "Prepago" });
            comboBoxEleccion.Location = new Point(309, 289);
            comboBoxEleccion.Name = "comboBoxEleccion";
            comboBoxEleccion.Size = new Size(100, 23);
            comboBoxEleccion.TabIndex = 10;
            comboBoxEleccion.SelectedIndexChanged += comboBoxEleccion_SelectedIndexChanged;
            // 
            // btnIngresarCliente
            // 
            btnIngresarCliente.Location = new Point(246, 123);
            btnIngresarCliente.Name = "btnIngresarCliente";
            btnIngresarCliente.Size = new Size(59, 38);
            btnIngresarCliente.TabIndex = 9;
            btnIngresarCliente.Text = "Ingresar Cliente";
            btnIngresarCliente.UseVisualStyleBackColor = true;
            btnIngresarCliente.Click += btnIngresarCliente_Click;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(127, 96);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(81, 23);
            txtNombreCliente.TabIndex = 8;
            // 
            // txtNitCliente
            // 
            txtNitCliente.Location = new Point(127, 188);
            txtNitCliente.Name = "txtNitCliente";
            txtNitCliente.Size = new Size(81, 23);
            txtNitCliente.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 188);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 6;
            label4.Text = "Nit";
            // 
            // TxtApellidoCliente
            // 
            TxtApellidoCliente.Location = new Point(127, 146);
            TxtApellidoCliente.Name = "TxtApellidoCliente";
            TxtApellidoCliente.Size = new Size(81, 23);
            TxtApellidoCliente.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnGenerarCierreDeCaja);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(dataGridViewCierreDeCaja);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(765, 416);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cierre de caja";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGenerarCierreDeCaja
            // 
            btnGenerarCierreDeCaja.Location = new Point(344, 387);
            btnGenerarCierreDeCaja.Name = "btnGenerarCierreDeCaja";
            btnGenerarCierreDeCaja.Size = new Size(75, 23);
            btnGenerarCierreDeCaja.TabIndex = 3;
            btnGenerarCierreDeCaja.Text = "Generar";
            btnGenerarCierreDeCaja.UseVisualStyleBackColor = true;
            btnGenerarCierreDeCaja.Click += btnGenerarCierreDeCaja_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(178, 10);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 2;
            label9.Text = "Elegir fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(282, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // dataGridViewCierreDeCaja
            // 
            dataGridViewCierreDeCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCierreDeCaja.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Nit, CodigoBomba, CodigoTipoDeDespacho, FechaHora, PrecioDia, CantidadDespacho, Total });
            dataGridViewCierreDeCaja.Location = new Point(6, 39);
            dataGridViewCierreDeCaja.Name = "dataGridViewCierreDeCaja";
            dataGridViewCierreDeCaja.Size = new Size(742, 339);
            dataGridViewCierreDeCaja.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Nit
            // 
            Nit.HeaderText = "Nit";
            Nit.Name = "Nit";
            // 
            // CodigoBomba
            // 
            CodigoBomba.HeaderText = "Bomba";
            CodigoBomba.Name = "CodigoBomba";
            // 
            // CodigoTipoDeDespacho
            // 
            CodigoTipoDeDespacho.HeaderText = "Tipo de despacho";
            CodigoTipoDeDespacho.Name = "CodigoTipoDeDespacho";
            // 
            // FechaHora
            // 
            FechaHora.HeaderText = "Fecha y Hora";
            FechaHora.Name = "FechaHora";
            // 
            // PrecioDia
            // 
            PrecioDia.HeaderText = "Precio del dia";
            PrecioDia.Name = "PrecioDia";
            // 
            // CantidadDespacho
            // 
            CantidadDespacho.HeaderText = "Cantidad Despachada";
            CantidadDespacho.Name = "CantidadDespacho";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnInformeGas);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(comboBoxAbasteciminento);
            tabPage3.Controls.Add(dataGridViewInformeAbastecimiento);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(765, 416);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Tipo de servicio";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnInformeGas
            // 
            btnInformeGas.Enabled = false;
            btnInformeGas.Location = new Point(331, 361);
            btnInformeGas.Name = "btnInformeGas";
            btnInformeGas.Size = new Size(75, 23);
            btnInformeGas.TabIndex = 3;
            btnInformeGas.Text = "Generar";
            btnInformeGas.UseVisualStyleBackColor = true;
            btnInformeGas.Click += btnInformeGas_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(208, 30);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 2;
            label10.Text = "Elegir";
            // 
            // comboBoxAbasteciminento
            // 
            comboBoxAbasteciminento.FormattingEnabled = true;
            comboBoxAbasteciminento.Items.AddRange(new object[] { "Tanque Lleno", "Prepago" });
            comboBoxAbasteciminento.Location = new Point(285, 30);
            comboBoxAbasteciminento.Name = "comboBoxAbasteciminento";
            comboBoxAbasteciminento.Size = new Size(121, 23);
            comboBoxAbasteciminento.TabIndex = 1;
            comboBoxAbasteciminento.SelectedIndexChanged += comboBoxAbasteciminento_SelectedIndexChanged;
            // 
            // dataGridViewInformeAbastecimiento
            // 
            dataGridViewInformeAbastecimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInformeAbastecimiento.Columns.AddRange(new DataGridViewColumn[] { NombreAbastecimiento, ApellidoAbastecimiento, NitAbastecimiento, BombaAbastecimiento, FechaHoraAbastecimiento, PrecioDiaAbastecimiento, CantidadDespachadaAbastecimiento, TotalAbastecimiento });
            dataGridViewInformeAbastecimiento.Location = new Point(6, 59);
            dataGridViewInformeAbastecimiento.Name = "dataGridViewInformeAbastecimiento";
            dataGridViewInformeAbastecimiento.Size = new Size(753, 271);
            dataGridViewInformeAbastecimiento.TabIndex = 0;
            // 
            // NombreAbastecimiento
            // 
            NombreAbastecimiento.HeaderText = "Nombre";
            NombreAbastecimiento.Name = "NombreAbastecimiento";
            // 
            // ApellidoAbastecimiento
            // 
            ApellidoAbastecimiento.HeaderText = "Apellido";
            ApellidoAbastecimiento.Name = "ApellidoAbastecimiento";
            // 
            // NitAbastecimiento
            // 
            NitAbastecimiento.HeaderText = "Nit";
            NitAbastecimiento.Name = "NitAbastecimiento";
            // 
            // BombaAbastecimiento
            // 
            BombaAbastecimiento.HeaderText = "Bomba";
            BombaAbastecimiento.Name = "BombaAbastecimiento";
            // 
            // FechaHoraAbastecimiento
            // 
            FechaHoraAbastecimiento.HeaderText = "Fecha y hora";
            FechaHoraAbastecimiento.Name = "FechaHoraAbastecimiento";
            // 
            // PrecioDiaAbastecimiento
            // 
            PrecioDiaAbastecimiento.HeaderText = "Precio del dia";
            PrecioDiaAbastecimiento.Name = "PrecioDiaAbastecimiento";
            // 
            // CantidadDespachadaAbastecimiento
            // 
            CantidadDespachadaAbastecimiento.HeaderText = "Cantidad despachada";
            CantidadDespachadaAbastecimiento.Name = "CantidadDespachadaAbastecimiento";
            // 
            // TotalAbastecimiento
            // 
            TotalAbastecimiento.HeaderText = "Total";
            TotalAbastecimiento.Name = "TotalAbastecimiento";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(txtBombaMasUsada);
            tabPage4.Controls.Add(btnGenerarBombaUsada);
            tabPage4.Controls.Add(comboBoxBombaUsada);
            tabPage4.Controls.Add(dataGridViewBombaUsada);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(765, 416);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Bombas usadas";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtBombaMasUsada
            // 
            txtBombaMasUsada.Enabled = false;
            txtBombaMasUsada.Location = new Point(332, 373);
            txtBombaMasUsada.Name = "txtBombaMasUsada";
            txtBombaMasUsada.Size = new Size(147, 23);
            txtBombaMasUsada.TabIndex = 8;
            // 
            // btnGenerarBombaUsada
            // 
            btnGenerarBombaUsada.Location = new Point(378, 327);
            btnGenerarBombaUsada.Name = "btnGenerarBombaUsada";
            btnGenerarBombaUsada.Size = new Size(75, 40);
            btnGenerarBombaUsada.TabIndex = 7;
            btnGenerarBombaUsada.Text = "Generar Informe";
            btnGenerarBombaUsada.UseVisualStyleBackColor = true;
            btnGenerarBombaUsada.Click += btnGenerarBombaUsada_Click;
            // 
            // comboBoxBombaUsada
            // 
            comboBoxBombaUsada.FormattingEnabled = true;
            comboBoxBombaUsada.Items.AddRange(new object[] { "1", "2" });
            comboBoxBombaUsada.Location = new Point(332, 6);
            comboBoxBombaUsada.Name = "comboBoxBombaUsada";
            comboBoxBombaUsada.Size = new Size(121, 23);
            comboBoxBombaUsada.TabIndex = 6;
            comboBoxBombaUsada.SelectedIndexChanged += comboBoxBombaUsada_SelectedIndexChanged;
            // 
            // dataGridViewBombaUsada
            // 
            dataGridViewBombaUsada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBombaUsada.Columns.AddRange(new DataGridViewColumn[] { NombreBomba, ApellidoBomba, NitBomba, bombaBombaUsada, tipoDespachoBomba, fechaHoraBomba, precioDiaBomba, cantidadDespachaBomba, totalBomba });
            dataGridViewBombaUsada.Location = new Point(17, 35);
            dataGridViewBombaUsada.Name = "dataGridViewBombaUsada";
            dataGridViewBombaUsada.Size = new Size(742, 286);
            dataGridViewBombaUsada.TabIndex = 5;
            // 
            // NombreBomba
            // 
            NombreBomba.HeaderText = "Nombre";
            NombreBomba.Name = "NombreBomba";
            // 
            // ApellidoBomba
            // 
            ApellidoBomba.HeaderText = "Apellido";
            ApellidoBomba.Name = "ApellidoBomba";
            // 
            // NitBomba
            // 
            NitBomba.HeaderText = "Nit";
            NitBomba.Name = "NitBomba";
            // 
            // bombaBombaUsada
            // 
            bombaBombaUsada.HeaderText = "Bomba";
            bombaBombaUsada.Name = "bombaBombaUsada";
            // 
            // tipoDespachoBomba
            // 
            tipoDespachoBomba.HeaderText = "Tipo de despacho";
            tipoDespachoBomba.Name = "tipoDespachoBomba";
            // 
            // fechaHoraBomba
            // 
            fechaHoraBomba.HeaderText = "Fecha y Hora";
            fechaHoraBomba.Name = "fechaHoraBomba";
            // 
            // precioDiaBomba
            // 
            precioDiaBomba.HeaderText = "Precio del dia";
            precioDiaBomba.Name = "precioDiaBomba";
            // 
            // cantidadDespachaBomba
            // 
            cantidadDespachaBomba.HeaderText = "Cantidad Despachada";
            cantidadDespachaBomba.Name = "cantidadDespachaBomba";
            // 
            // totalBomba
            // 
            totalBomba.HeaderText = "Total";
            totalBomba.Name = "totalBomba";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 468);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCierreDeCaja).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInformeAbastecimiento).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBombaUsada).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCapacidadBomba;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox TxtApellidoCliente;
        private TabPage tabPage2;
        private TextBox txtNitCliente;
        private Label label4;
        private TextBox txtNombreCliente;
        private Button btnIngresarCliente;
        private ComboBox comboBoxEleccion;
        private Label label5;
        private Button btnElegirBomba;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBoxElegirBomba;
        private TextBox txtCantidadDespachar;
        private Label label7;
        private Button btnDespacharGasolina;
        private Label label6;
        private DataGridView dataGridViewCierreDeCaja;
        private Button btnGenerarCierreDeCaja;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nit;
        private DataGridViewTextBoxColumn CodigoBomba;
        private DataGridViewTextBoxColumn CodigoTipoDeDespacho;
        private DataGridViewTextBoxColumn FechaHora;
        private DataGridViewTextBoxColumn PrecioDia;
        private DataGridViewTextBoxColumn CantidadDespacho;
        private DataGridViewTextBoxColumn Total;
        private TabPage tabPage3;
        private Button btnInformeGas;
        private Label label10;
        private ComboBox comboBoxAbasteciminento;
        private DataGridView dataGridViewInformeAbastecimiento;
        private DataGridViewTextBoxColumn NombreAbastecimiento;
        private DataGridViewTextBoxColumn ApellidoAbastecimiento;
        private DataGridViewTextBoxColumn NitAbastecimiento;
        private DataGridViewTextBoxColumn BombaAbastecimiento;
        private DataGridViewTextBoxColumn FechaHoraAbastecimiento;
        private DataGridViewTextBoxColumn PrecioDiaAbastecimiento;
        private DataGridViewTextBoxColumn CantidadDespachadaAbastecimiento;
        private DataGridViewTextBoxColumn TotalAbastecimiento;
        private TabPage tabPage4;
        private DataGridView dataGridViewBombaUsada;
        private DataGridViewTextBoxColumn NombreBomba;
        private DataGridViewTextBoxColumn ApellidoBomba;
        private DataGridViewTextBoxColumn NitBomba;
        private DataGridViewTextBoxColumn bombaBombaUsada;
        private DataGridViewTextBoxColumn tipoDespachoBomba;
        private DataGridViewTextBoxColumn fechaHoraBomba;
        private DataGridViewTextBoxColumn precioDiaBomba;
        private DataGridViewTextBoxColumn cantidadDespachaBomba;
        private DataGridViewTextBoxColumn totalBomba;
        private ComboBox comboBoxBombaUsada;
        private Button btnGenerarBombaUsada;
        private TextBox txtBombaMasUsada;
        private Label label11;
        private Label label14;
        private Label label13;
        private Label label12;
    }
}
