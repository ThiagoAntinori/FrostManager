-- Script de carga inicial de patentes nativas del sistema
-- Tabla: PATENTE (IdPatente UNIQUEIDENTIFIER, Nombre VARCHAR(100), MenuItemName VARCHAR(100), FormName VARCHAR(100))

INSERT INTO PATENTE (IdPatente, Nombre, MenuItemName, FormName) VALUES
(NEWID(), 'REGISTRAR_VENTA', 'btnRegistrarVenta', 'RegistrarVentaForm'),
(NEWID(), 'REGISTRAR_CLIENTE', 'btnRegistrarCliente', 'RegistrarClienteForm'),
(NEWID(), 'MODIFICAR_CLIENTE', 'btnModificarCliente', 'ModificarClienteForm'),
(NEWID(), 'CONSULTAR_CLIENTE', 'btnConsultarCliente', 'ConsultarClienteForm'),
(NEWID(), 'VER_PEDIDOS', 'btnVerPedidos', 'VerPedidosForm'),
(NEWID(), 'ACTUALIZAR_PEDIDO', 'btnActualizarPedido', 'ActualizarPedidoForm'),
(NEWID(), 'CANCELAR_PEDIDO', 'btnCancelarPedido', 'CancelarPedidoForm'),
(NEWID(), 'REGISTAR_INGRESO', 'btnRegistrarIngreso', 'RegistrarIngresoForm'),
(NEWID(), 'REGISTRAR_EGRESO', 'btnRegistrarEgreso', 'RegistrarEgresoForm'),
(NEWID(), 'REGISTRAR_INSUMO', 'btnRegistrarInsumo', 'RegistrarInsumoForm'),
(NEWID(), 'AJUSTAR_STOCK', 'btnAjustarStock', 'AjustarStockForm'),
(NEWID(), 'CONSULTAR_STOCK', 'btnConsultarStock', 'ConsultarStockForm'),
(NEWID(), 'REPORTE_VENTAS', 'btnReporteVentas', 'ReporteVentasForm'),
(NEWID(), 'CIERRE_CAJA', 'btnCierreCaja', 'CierreCajaForm'),
(NEWID(), 'REPORTE_SABORES', 'btnReporteSabores', 'ReporteSaboresForm'),
(NEWID(), 'REPORTE_ENTREGAS', 'btnReporteEntregas', 'ReporteEntregasForm'),
(NEWID(), 'REPORTE_PROYECCION', 'btnReporteProyecciones', 'ReporteProyeccionForm'),
(NEWID(), 'PANEL_ADMINISTRATIVO', 'btnAbrirPanelAdministrativo', 'MainAdministrativeForm');

-- Script de carga inicial de familias nativas del sistema

DECLARE @IdFamiliaAtencion UNIQUEIDENTIFIER = NEWID()
DECLARE @IdFamiliaInventario UNIQUEIDENTIFIER = NEWID()
DECLARE @IdFamiliaAdministrador UNIQUEIDENTIFIER = NEWID()

INSERT INTO FAMILIA (IdFamilia, Nombre) VALUES
(@IdFamiliaAtencion, 'ATENCION_AL_CLIENTE'),
(@IdFamiliaInventario, 'CONTROL_DE_INVENTARIO'),
(@IdFamiliaAdministrador, 'ADMINISTRADOR');

-- Asociacion de patentes
INSERT INTO FAMILIA_PATENTE (IdFamilia, IdPatente)
SELECT @IdFamiliaAtencion, IdPatente 
FROM PATENTE 
WHERE Nombre IN ('REGISTRAR_VENTA', 'REGISTRAR_CLIENTE', 'MODIFICAR_CLIENTE', 'CONSULTAR_CLIENTE', 'VER_PEDIDOS', 'ACTUALIZAR_PEDIDO', 'CANCELAR_PEDIDO', 'CIERRE_CAJA');

INSERT INTO FAMILIA_PATENTE (IdFamilia, IdPatente)
SELECT @IdFamiliaInventario, IdPatente
FROM PATENTE
WHERE Nombre IN ('REGISTRAR_INGRESO', 'REGISTRAR_EGRESO', 'REGISTRAR_INSUMO', 'AJUSTAR_STOCK', 'CONSULTAR_STOCK')

INSERT INTO FAMILIA_PATENTE (IdFamilia, IdPatente)
SELECT @IdFamiliaAdministrador, IdPatente
FROM PATENTE
WHERE Nombre IN ('REPORTE_VENTAS', 'REPORTE_SABORES', 'REPORTE_ENTREGAS', 'REPORTE_PROYECCION', 'PANEL_ADMINISTRATIVO')

INSERT INTO FAMILIA_FAMILIA (IdFamiliaPadre, IdFamiliaHijo)
SELECT @IdFamiliaAdministrador, @IdFamiliaInventario

INSERT INTO FAMILIA_FAMILIA (IdFamiliaPadre, IdFamiliaHijo)
SELECT @IdFamiliaAdministrador, @IdFamiliaAtencion

-- ==============================
-- CREACIN DEL USUARIO ADMIN
-- ==============================

DECLARE @IdAdmin UNIQUEIDENTIFIER = NEWID();

-- Insertar usuario admin si no existe
IF NOT EXISTS (SELECT 1 FROM USUARIO WHERE Nombre = 'admin')
BEGIN
    INSERT INTO USUARIO (IdUsuario, CorreoElectronico, Nombre, Password, EstaHabilitado)
    VALUES (
        @IdAdmin,
        'admin@frostmanager.com',
        'admin',
        '0f037584c99e7fd4f4f8c59550f8f507', -- Hash de '1234'
        1
    );
END
ELSE
BEGIN
    SELECT @AdminId = IdUsuario FROM USUARIO WHERE Nombre = 'admin';
END

-- ==============================
-- ASOCIACION DEL ADMIN A SU FAMILIA
-- ==============================

INSERT INTO USUARIO_FAMILIA (IdUsuario, IdFamilia)
VALUES (@AdminId, @IdFamiliaAdministrador)

-- ================
-- CARGA INICIAL DE ENUMS
-- ==================

INSERT INTO TipoMovimientoStock (IdTipoMovimientoStock, Descripcion, Borrado) VALUES (1, 'Ingreso', 0);
INSERT INTO TipoMovimientoStock (IdTipoMovimientoStock, Descripcion, Borrado) VALUES (2, 'Egreso', 0);
INSERT INTO TipoMovimientoStock (IdTipoMovimientoStock, Descripcion, Borrado) VALUES (3, 'Ajuste', 0);

INSERT INTO MedioPago (IdMedioPago, Descripcion, Borrado) VALUES (1, 'Efectivo', 0);
INSERT INTO MedioPago (IdMedioPago, Descripcion, Borrado) VALUES (2, 'Transferencia', 0);
INSERT INTO MedioPago (IdMedioPago, Descripcion, Borrado) VALUES (3, 'Tarjeta', 0);

INSERT INTO EstadoVenta (IdEstadoVenta, Descripcion, Borrado) VALUES (1, 'EnCurso', 0);
INSERT INTO EstadoVenta (IdEstadoVenta, Descripcion, Borrado) VALUES (2, 'PendienteDePago', 0);
INSERT INTO EstadoVenta (IdEstadoVenta, Descripcion, Borrado) VALUES (3, 'PendienteDeEntrega', 0);
INSERT INTO EstadoVenta (IdEstadoVenta, Descripcion, Borrado) VALUES (4, 'Finalizada', 0);

INSERT INTO EstadoPedido (IdEstadoPedido, Descripcion, Borrado) VALUES (1, 'EnPreparacion', 0);
INSERT INTO EstadoPedido (IdEstadoPedido, Descripcion, Borrado) VALUES (2, 'EnCamino', 0);
INSERT INTO EstadoPedido (IdEstadoPedido, Descripcion, Borrado) VALUES (3, 'Entregado', 0);