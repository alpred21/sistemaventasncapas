select U.NOMBREUSER, R.NOMBRE, U.CONTRASEŅA, UR.ESTADO, UR.IDROL
from USUARIOROL UR
inner join ROL R ON UR.IDROL=R.IDROL
INNER JOIN USUARIO U ON UR.IDUSUARIO=U.IDUSUARIO 
ORDER BY R.NOMBRE	

USE TIENDABD

SELECT IDPERSONA,NOMBRE,APELLIDO,TELEFONO,CI,CORREO FROM PERSONA WHERE ESTADO='ACTIVO'
UPDATE PERSONA SET ESTADO='INACTIVO'
SELECT IDPERSONA,IDCLIENTE,TIPOCLIENTE,CODIGOCLIENTE FROM CLIENTE WHERE ESTADO='ACTIVO'

SELECT IDUSUARIOROL,IDUSUARIO,IDROL,FECHAASIGNA FROM usuariorol WHERE ESTADO='ACTIVO'
SELECT IDVENTA,IDCLIENTE,IDVENDEDOR,FECHA,TOTAL FROM venta WHERE ESTADO='EXITOSO'
SELECT IDTIPOPROD,NOMBRE FROM tipoprod WHERE ESTADO='ACTIVO'
SELECT IDROL,NOMBRE FROM ROL WHERE ESTADO='ACTIVO'
SELECT * FROM usuario
select * from USUARIOROL
SELECT IDPROVEEDOR,NOMBRE,TELEFONO,DIRECCION FROM PROVEEDOR WHERE ESTADO='ACTIVO'
SELECT * FROM PROVEE
SELECT IDPRODUCTO,IDTIPOPROD,IDMARCA,NOMBRE,CODIGOBARRA,UNIDAD,DESCRIPCION FROM PRODUCTO WHERE ESTADO='ACTIVO'
SELECT IDMARCA,NOMBRE FROM MARCA WHERE ESTADO='ACTIVO'
SELECT IDINGRESO,IDPROVEEDOR,FECHAINGRESO,TOTAL FROM INGRESO WHERE ESTADO='ACTIVO'
SELECT IDDETALLEVENTA,IDVENTA,IDPRODUCTO,CANTIDAD,PRECIOVENTA,SUBTOTAL FROM DETALLEVENTA WHERE ESTADO='EXITOSO'
SELECT IDDETALLEING,IDINGRESO,IDPRODUCTO,FECHAVENC,CANTIDAD,PRECIOCOSTO,PRECIOVENTA,SUBTOTAL FROM DETALLEING WHERE  ESTADO='EXITOSO'
SELECT * FROM DETALLEING




