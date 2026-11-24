namespace Examen1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new System.Windows.Forms.Button();
            this.lvCatalogo = new System.Windows.Forms.ListView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.rbtnMostrador = new System.Windows.Forms.RadioButton();
            this.rbtnEntrega = new System.Windows.Forms.RadioButton();
            this.chkServilletas = new System.Windows.Forms.CheckBox();
            this.lvPedido = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkPostre = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(12, 16);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(543, 404);
            this.btn.TabIndex = 0;
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lvCatalogo
            // 
            this.lvCatalogo.FullRowSelect = true;
            this.lvCatalogo.HideSelection = false;
            this.lvCatalogo.Location = new System.Drawing.Point(46, 136);
            this.lvCatalogo.Name = "lvCatalogo";
            this.lvCatalogo.Size = new System.Drawing.Size(225, 204);
            this.lvCatalogo.TabIndex = 2;
            this.lvCatalogo.UseCompatibleStateImageBehavior = false;
            this.lvCatalogo.View = System.Windows.Forms.View.Details;
            this.lvCatalogo.Visible = false;
            this.lvCatalogo.SelectedIndexChanged += new System.EventHandler(this.lvCatalogo_SelectedIndexChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(109, 36);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(196, 20);
            this.txtCliente.TabIndex = 3;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(109, 62);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(196, 20);
            this.txtProducto.TabIndex = 4;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(393, 57);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(45, 20);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // rbtnMostrador
            // 
            this.rbtnMostrador.AutoSize = true;
            this.rbtnMostrador.Checked = true;
            this.rbtnMostrador.Location = new System.Drawing.Point(334, 112);
            this.rbtnMostrador.Name = "rbtnMostrador";
            this.rbtnMostrador.Size = new System.Drawing.Size(117, 17);
            this.rbtnMostrador.TabIndex = 6;
            this.rbtnMostrador.TabStop = true;
            this.rbtnMostrador.Text = "Retiro en mostrador";
            this.rbtnMostrador.UseVisualStyleBackColor = true;
            // 
            // rbtnEntrega
            // 
            this.rbtnEntrega.AutoSize = true;
            this.rbtnEntrega.Location = new System.Drawing.Point(334, 181);
            this.rbtnEntrega.Name = "rbtnEntrega";
            this.rbtnEntrega.Size = new System.Drawing.Size(143, 17);
            this.rbtnEntrega.TabIndex = 7;
            this.rbtnEntrega.Text = "Entrega en Aula (+$0.50)";
            this.rbtnEntrega.UseVisualStyleBackColor = true;
            this.rbtnEntrega.CheckedChanged += new System.EventHandler(this.rbtnEntrega_CheckedChanged);
            // 
            // chkServilletas
            // 
            this.chkServilletas.AutoSize = true;
            this.chkServilletas.Location = new System.Drawing.Point(334, 136);
            this.chkServilletas.Name = "chkServilletas";
            this.chkServilletas.Size = new System.Drawing.Size(129, 17);
            this.chkServilletas.TabIndex = 9;
            this.chkServilletas.Text = "Servilletas / Cubiertos";
            this.chkServilletas.UseVisualStyleBackColor = true;
            this.chkServilletas.CheckedChanged += new System.EventHandler(this.chkServilletas_CheckedChanged);
            // 
            // lvPedido
            // 
            this.lvPedido.FullRowSelect = true;
            this.lvPedido.HideSelection = false;
            this.lvPedido.Location = new System.Drawing.Point(309, 233);
            this.lvPedido.Name = "lvPedido";
            this.lvPedido.Size = new System.Drawing.Size(234, 133);
            this.lvPedido.TabIndex = 10;
            this.lvPedido.UseCompatibleStateImageBehavior = false;
            this.lvPedido.View = System.Windows.Forms.View.Details;
            this.lvPedido.SelectedIndexChanged += new System.EventHandler(this.lvPedido_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(464, 51);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 31);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar Ítem";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(349, 393);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(87, 23);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.Text = "Quitar Seleccionado\"";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(442, 393);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar Pedido ";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(67, 398);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(162, 13);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado: Seleccione un producto.";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(439, 369);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total: $0.00";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // chkPostre
            // 
            this.chkPostre.AutoSize = true;
            this.chkPostre.Location = new System.Drawing.Point(334, 158);
            this.chkPostre.Name = "chkPostre";
            this.chkPostre.Size = new System.Drawing.Size(134, 17);
            this.chkPostre.TabIndex = 16;
            this.chkPostre.Text = "Postre del día (+$1.00)";
            this.chkPostre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "producto ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cantidad ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(50, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Catalogo de productos ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(319, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "extras ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(319, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "pedido actual ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkPostre);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lvPedido);
            this.Controls.Add(this.chkServilletas);
            this.Controls.Add(this.rbtnEntrega);
            this.Controls.Add(this.rbtnMostrador);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lvCatalogo);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ListView lvCatalogo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.RadioButton rbtnMostrador;
        private System.Windows.Forms.RadioButton rbtnEntrega;
        private System.Windows.Forms.CheckBox chkServilletas;
        private System.Windows.Forms.ListView lvPedido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkPostre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

