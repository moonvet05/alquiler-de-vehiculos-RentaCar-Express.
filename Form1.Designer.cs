namespace Examen_RentaCar_Thomas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblCliente = new Label();
            textCliente = new TextBox();
            dtpSalida = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txtVehiculo = new TextBox();
            lblTarifa = new Label();
            textTarifa = new TextBox();
            lblDias = new Label();
            nudDias = new NumericUpDown();
            groupBox1 = new GroupBox();
            rbtCompleto = new RadioButton();
            rbtBasico = new RadioButton();
            groupBox2 = new GroupBox();
            rbtDomicilio = new RadioButton();
            rbtSucursal = new RadioButton();
            chkGps = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            lblEncabezado = new Label();
            lstAlquileres = new ListBox();
            label9 = new Label();
            label8 = new Label();
            label00 = new Label();
            label88 = new Label();
            label11 = new Label();
            chkCorporativo = new CheckBox();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            lblDomicilio = new Label();
            lblITBIS = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblCliente
            // 
            resources.ApplyResources(lblCliente, "lblCliente");
            lblCliente.Name = "lblCliente";
            // 
            // textCliente
            // 
            resources.ApplyResources(textCliente, "textCliente");
            textCliente.Name = "textCliente";
            textCliente.TextChanged += textCliente_TextChanged;
            // 
            // dtpSalida
            // 
            resources.ApplyResources(dtpSalida, "dtpSalida");
            dtpSalida.Name = "dtpSalida";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // txtVehiculo
            // 
            resources.ApplyResources(txtVehiculo, "txtVehiculo");
            txtVehiculo.Name = "txtVehiculo";
            // 
            // lblTarifa
            // 
            resources.ApplyResources(lblTarifa, "lblTarifa");
            lblTarifa.Name = "lblTarifa";
            // 
            // textTarifa
            // 
            resources.ApplyResources(textTarifa, "textTarifa");
            textTarifa.Name = "textTarifa";
            // 
            // lblDias
            // 
            resources.ApplyResources(lblDias, "lblDias");
            lblDias.Name = "lblDias";
            // 
            // nudDias
            // 
            resources.ApplyResources(nudDias, "nudDias");
            nudDias.Name = "nudDias";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtCompleto);
            groupBox1.Controls.Add(rbtBasico);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // rbtCompleto
            // 
            resources.ApplyResources(rbtCompleto, "rbtCompleto");
            rbtCompleto.Name = "rbtCompleto";
            rbtCompleto.TabStop = true;
            rbtCompleto.UseVisualStyleBackColor = true;
            // 
            // rbtBasico
            // 
            resources.ApplyResources(rbtBasico, "rbtBasico");
            rbtBasico.Name = "rbtBasico";
            rbtBasico.TabStop = true;
            rbtBasico.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtDomicilio);
            groupBox2.Controls.Add(rbtSucursal);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // rbtDomicilio
            // 
            resources.ApplyResources(rbtDomicilio, "rbtDomicilio");
            rbtDomicilio.Name = "rbtDomicilio";
            rbtDomicilio.TabStop = true;
            rbtDomicilio.UseVisualStyleBackColor = true;
            // 
            // rbtSucursal
            // 
            resources.ApplyResources(rbtSucursal, "rbtSucursal");
            rbtSucursal.Name = "rbtSucursal";
            rbtSucursal.TabStop = true;
            rbtSucursal.UseVisualStyleBackColor = true;
            // 
            // chkGps
            // 
            resources.ApplyResources(chkGps, "chkGps");
            chkGps.Name = "chkGps";
            chkGps.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            resources.ApplyResources(btnCalcular, "btnCalcular");
            btnCalcular.Name = "btnCalcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            resources.ApplyResources(btnLimpiar, "btnLimpiar");
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            resources.ApplyResources(btnSalir, "btnSalir");
            btnSalir.Name = "btnSalir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            resources.ApplyResources(btnAgregar, "btnAgregar");
            btnAgregar.Name = "btnAgregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblEncabezado
            // 
            resources.ApplyResources(lblEncabezado, "lblEncabezado");
            lblEncabezado.ForeColor = SystemColors.ControlText;
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Click += label5_Click;
            // 
            // lstAlquileres
            // 
            lstAlquileres.FormattingEnabled = true;
            resources.ApplyResources(lstAlquileres, "lstAlquileres");
            lstAlquileres.Name = "lstAlquileres";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // label00
            // 
            resources.ApplyResources(label00, "label00");
            label00.Name = "label00";
            // 
            // label88
            // 
            resources.ApplyResources(label88, "label88");
            label88.Name = "label88";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // chkCorporativo
            // 
            resources.ApplyResources(chkCorporativo, "chkCorporativo");
            chkCorporativo.Name = "chkCorporativo";
            chkCorporativo.UseVisualStyleBackColor = true;
            // 
            // lblSubtotal
            // 
            resources.ApplyResources(lblSubtotal, "lblSubtotal");
            lblSubtotal.Name = "lblSubtotal";
            // 
            // lblDescuento
            // 
            resources.ApplyResources(lblDescuento, "lblDescuento");
            lblDescuento.Name = "lblDescuento";
            // 
            // lblDomicilio
            // 
            resources.ApplyResources(lblDomicilio, "lblDomicilio");
            lblDomicilio.Name = "lblDomicilio";
            // 
            // lblITBIS
            // 
            resources.ApplyResources(lblITBIS, "lblITBIS");
            lblITBIS.Name = "lblITBIS";
            // 
            // lblTotal
            // 
            resources.ApplyResources(lblTotal, "lblTotal");
            lblTotal.Name = "lblTotal";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTotal);
            Controls.Add(lblITBIS);
            Controls.Add(lblDomicilio);
            Controls.Add(lblDescuento);
            Controls.Add(lblSubtotal);
            Controls.Add(chkCorporativo);
            Controls.Add(label11);
            Controls.Add(label88);
            Controls.Add(label00);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(lstAlquileres);
            Controls.Add(lblEncabezado);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(chkGps);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(nudDias);
            Controls.Add(lblDias);
            Controls.Add(textTarifa);
            Controls.Add(lblTarifa);
            Controls.Add(txtVehiculo);
            Controls.Add(label2);
            Controls.Add(dtpSalida);
            Controls.Add(label1);
            Controls.Add(textCliente);
            Controls.Add(lblCliente);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private TextBox textCliente;
        private DateTimePicker dtpSalida;
        private Label label1;
        private Label label2;
        private TextBox txtVehiculo;
        private Label lblTarifa;
        private TextBox textTarifa;
        private Label lblDias;
        private NumericUpDown nudDias;
        private GroupBox groupBox1;
        private RadioButton rbtCompleto;
        private RadioButton rbtBasico;
        private GroupBox groupBox2;
        private RadioButton rbtDomicilio;
        private RadioButton rbtSucursal;
        private CheckBox chkGps;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnAgregar;
        private Label lblEncabezado;
        private ListBox lstAlquileres;
        private Label label9;
        private Label label8;
        private Label label00;
        private Label label88;
        private Label label11;
        private CheckBox chkCorporativo;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblDomicilio;
        private Label lblITBIS;
        private Label lblTotal;
    }
}
