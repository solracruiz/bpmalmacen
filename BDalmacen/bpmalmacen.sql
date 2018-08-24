SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

DROP SCHEMA IF EXISTS `bpmalmacen` ;
CREATE SCHEMA IF NOT EXISTS `bpmalmacen` DEFAULT CHARACTER SET latin1 ;
USE `bpmalmacen` ;

-- -----------------------------------------------------
-- Table `bpmalmacen`.`catalmacen`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`catalmacen` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`catalmacen` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `clave` VARCHAR(45) NOT NULL DEFAULT '',
  `nombre` VARCHAR(45) NOT NULL DEFAULT '',
  `calle` VARCHAR(45) NOT NULL DEFAULT '',
  `numinterior` VARCHAR(45) NOT NULL DEFAULT '',
  `numexterior` VARCHAR(45) NOT NULL DEFAULT '',
  `telefonofijo` VARCHAR(45) NOT NULL DEFAULT '',
  `responsable` VARCHAR(45) NOT NULL DEFAULT '',
  `celular` VARCHAR(45) NOT NULL DEFAULT '',
  `cp` VARCHAR(45) NOT NULL DEFAULT '',
  `ciudad` VARCHAR(45) NOT NULL DEFAULT '',
  `email` VARCHAR(45) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `bpmalmacen`.`empleados`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`empleados` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`empleados` (
  `id` INT NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `apellidos` VARCHAR(45) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bpmalmacen`.`bajas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`bajas` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`bajas` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `fechabaja` DATE NOT NULL,
  `estatus` CHAR(1) NOT NULL DEFAULT '',
  `idalmacen` INT NOT NULL,
  `idtestigo` INT NOT NULL,
  `idautorizo` INT NOT NULL,
  `numdocto` VARCHAR(45) NOT NULL DEFAULT '',
  `tipo` VARCHAR(15) NOT NULL DEFAULT '',
  `catalmacen_id` INT(10) UNSIGNED NOT NULL,
  `empleados_id` INT NOT NULL,
  `empleados_id1` INT NOT NULL,
  `empleados_id2` INT NOT NULL,
  `empleados_id3` INT NOT NULL,
  PRIMARY KEY (`id`, `catalmacen_id`, `empleados_id`, `empleados_id1`, `empleados_id2`, `empleados_id3`),
  CONSTRAINT `fk_bajas_catalmacen1`
    FOREIGN KEY (`catalmacen_id`)
    REFERENCES `bpmalmacen`.`catalmacen` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_bajas_empleados1`
    FOREIGN KEY (`empleados_id2`)
    REFERENCES `bpmalmacen`.`empleados` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_bajas_empleados2`
    FOREIGN KEY (`empleados_id3`)
    REFERENCES `bpmalmacen`.`empleados` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `id_testigo` ON `bpmalmacen`.`bajas` (`idtestigo` ASC);

CREATE INDEX `id_autorizo` ON `bpmalmacen`.`bajas` (`idautorizo` ASC);

CREATE INDEX `id_almacen` ON `bpmalmacen`.`bajas` (`idalmacen` ASC);

CREATE INDEX `fk_bajas_catalmacen1_idx` ON `bpmalmacen`.`bajas` (`catalmacen_id` ASC);

CREATE INDEX `fk_bajas_empleados1_idx` ON `bpmalmacen`.`bajas` (`empleados_id2` ASC);

CREATE INDEX `fk_bajas_empleados2_idx` ON `bpmalmacen`.`bajas` (`empleados_id3` ASC);


-- -----------------------------------------------------
-- Table `bpmalmacen`.`usuarios`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`usuarios` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`usuarios` (
  `usuario` VARCHAR(15) NOT NULL DEFAULT '',
  `password` VARCHAR(15) NOT NULL DEFAULT '',
  `permisos` VARCHAR(200) NOT NULL DEFAULT '0',
  `estado` CHAR(1) NULL DEFAULT '1',
  `nombre` VARCHAR(45) NOT NULL DEFAULT '',
  `numero` VARCHAR(45) NOT NULL DEFAULT '',
  `idalmacen` INT NOT NULL DEFAULT '0',
  `catalmacen_id` INT(10) UNSIGNED NOT NULL,
  `idempleado` INT NULL,
  `empleados_id` INT NOT NULL,
  PRIMARY KEY (`usuario`, `catalmacen_id`, `empleados_id`))
ENGINE = MyISAM
AUTO_INCREMENT = 36;

CREATE INDEX `id_almacen` ON `bpmalmacen`.`usuarios` (`idalmacen` ASC);

CREATE INDEX `fk_usuarios_catalmacen1_idx` ON `bpmalmacen`.`usuarios` (`catalmacen_id` ASC);

CREATE UNIQUE INDEX `idempleado_UNIQUE` ON `bpmalmacen`.`usuarios` (`idempleado` ASC);

CREATE INDEX `fk_usuarios_empleados1_idx` ON `bpmalmacen`.`usuarios` (`empleados_id` ASC);


-- -----------------------------------------------------
-- Table `bpmalmacen`.`bitacora`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`bitacora` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`bitacora` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `clave` INT(10) UNSIGNED NOT NULL DEFAULT '0',
  `fecha` DATE NOT NULL,
  `fechasis` DATETIME NOT NULL,
  `usuario` VARCHAR(15) NOT NULL DEFAULT '',
  `tabla` VARCHAR(15) NOT NULL DEFAULT '',
  `motivo` VARCHAR(100) NOT NULL,
  `usuarios_usuario` VARCHAR(15) NOT NULL,
  `idtabla` INT NULL,
  PRIMARY KEY (`id`, `usuarios_usuario`))
ENGINE = MyISAM
AUTO_INCREMENT = 353105;

CREATE INDEX `usuario` ON `bpmalmacen`.`bitacora` (`usuario` ASC);

CREATE INDEX `fk_bitacora_usuarios_idx` ON `bpmalmacen`.`bitacora` (`usuarios_usuario` ASC);


-- -----------------------------------------------------
-- Table `bpmalmacen`.`catareas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`catareas` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`catareas` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `clave` VARCHAR(10) NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  `idjefe` INT NULL,
  `empleados_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_catareas_empleados1`
    FOREIGN KEY (`empleados_id`)
    REFERENCES `bpmalmacen`.`empleados` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 5;

CREATE INDEX `id_jefe` ON `bpmalmacen`.`catareas` (`idjefe` ASC);

CREATE INDEX `fk_catareas_empleados1_idx` ON `bpmalmacen`.`catareas` (`empleados_id` ASC);


-- -----------------------------------------------------
-- Table `bpmalmacen`.`catpartidas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`catpartidas` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`catpartidas` (
  `id` VARCHAR(5) NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 5;


-- -----------------------------------------------------
-- Table `bpmalmacen`.`cattipoarticulos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`cattipoarticulos` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`cattipoarticulos` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 5;


-- -----------------------------------------------------
-- Table `bpmalmacen`.`presentacion`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`presentacion` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`presentacion` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `clave` VARCHAR(5) NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bpmalmacen`.`catarticulos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`catarticulos` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`catarticulos` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `idpartida` VARCHAR(5) NOT NULL,
  `codigo` VARCHAR(25) NOT NULL,
  `nombre_corto` VARCHAR(40) NOT NULL,
  `nombre_largo` VARCHAR(100) NOT NULL,
  `idpresentacion` INT NOT NULL,
  `idtipo` INT NOT NULL,
  `marbete` VARCHAR(45) NULL,
  `ubicacion` VARCHAR(45) NULL,
  `foto` LONGBLOB NULL,
  `preciopromedio` INT NOT NULL DEFAULT 0,
  `catpartidas_id` VARCHAR(5) NOT NULL,
  `cattipoarticulos_id` INT(10) UNSIGNED NOT NULL,
  `presentacion_id` INT NOT NULL,
  PRIMARY KEY (`id`, `catpartidas_id`, `cattipoarticulos_id`, `presentacion_id`),
  CONSTRAINT `fk_catarticulos_catpartidas1`
    FOREIGN KEY (`catpartidas_id`)
    REFERENCES `bpmalmacen`.`catpartidas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_catarticulos_cattipoarticulos1`
    FOREIGN KEY (`cattipoarticulos_id`)
    REFERENCES `bpmalmacen`.`cattipoarticulos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_catarticulos_presentacion1`
    FOREIGN KEY (`presentacion_id`)
    REFERENCES `bpmalmacen`.`presentacion` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `id_partida` ON `bpmalmacen`.`catarticulos` (`idpartida` ASC);

CREATE INDEX `fk_catarticulos_catpartidas1_idx` ON `bpmalmacen`.`catarticulos` (`catpartidas_id` ASC);

CREATE INDEX `id_tipo` ON `bpmalmacen`.`catarticulos` (`idtipo` ASC);

CREATE INDEX `fk_catarticulos_cattipoarticulos1_idx` ON `bpmalmacen`.`catarticulos` (`cattipoarticulos_id` ASC);

CREATE INDEX `id_presentacion` ON `bpmalmacen`.`catarticulos` (`idpresentacion` ASC);

CREATE INDEX `fk_catarticulos_presentacion1_idx` ON `bpmalmacen`.`catarticulos` (`presentacion_id` ASC);


-- -----------------------------------------------------
-- Table `bpmalmacen`.`catmarcas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`catmarcas` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`catmarcas` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `clave` VARCHAR(45) NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `bpmalmacen`.`catproveedores`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`catproveedores` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`catproveedores` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL DEFAULT '',
  `rfc` VARCHAR(13) NOT NULL DEFAULT '',
  `calle` VARCHAR(45) NOT NULL DEFAULT '',
  `numext` VARCHAR(5) NOT NULL DEFAULT '',
  `numint` VARCHAR(15) NOT NULL DEFAULT '',
  `cp` VARCHAR(5) NOT NULL DEFAULT '',
  `colonia` VARCHAR(45) NOT NULL DEFAULT '',
  `localidad` VARCHAR(45) NOT NULL DEFAULT '',
  `municipio` VARCHAR(45) NOT NULL DEFAULT '',
  `estado` VARCHAR(45) NOT NULL DEFAULT '',
  `pais` VARCHAR(45) NOT NULL DEFAULT '',
  `telefonofijo` VARCHAR(15) NOT NULL DEFAULT '',
  `celular` VARCHAR(15) NOT NULL DEFAULT '',
  `email` VARCHAR(45) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 6;

CREATE UNIQUE INDEX `rfc_UNIQUE` ON `bpmalmacen`.`catproveedores` (`rfc` ASC);


-- -----------------------------------------------------
-- Table `bpmalmacen`.`configuracion`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`configuracion` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`configuracion` (
  `clave` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `reportes` VARCHAR(45) NOT NULL DEFAULT '',
  `nombre` VARCHAR(45) NOT NULL DEFAULT '',
  `jeferh` VARCHAR(200) NOT NULL DEFAULT '',
  `jefecentro` VARCHAR(200) NOT NULL DEFAULT '',
  `directorcentro` VARCHAR(200) NOT NULL DEFAULT '',
  `rfc` VARCHAR(15) NULL DEFAULT '',
  `calle` VARCHAR(45) NOT NULL DEFAULT '',
  `colonia` VARCHAR(45) NOT NULL DEFAULT '',
  `municipio` VARCHAR(45) NOT NULL DEFAULT '',
  PRIMARY KEY (`clave`))
ENGINE = MyISAM
AUTO_INCREMENT = 2;


-- -----------------------------------------------------
-- Table `bpmalmacen`.`entradas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`entradas` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`entradas` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `idproveedor` INT NOT NULL,
  `idarea` INT NOT NULL,
  `idalmacen` INT NOT NULL,
  `tipo` VARCHAR(10) NOT NULL,
  `estatus` CHAR(1) NOT NULL DEFAULT 1,
  `fechaentrada` DATE NOT NULL,
  `numfactura` VARCHAR(45) NOT NULL DEFAULT '',
  `fechafactura` DATE NOT NULL,
  `costofactura` INT NOT NULL,
  `observaciones` VARCHAR(100) NOT NULL DEFAULT '',
  `idrecibio` INT NOT NULL,
  `catproveedores_id` INT(10) UNSIGNED NOT NULL,
  `empleados_id` INT NOT NULL,
  `usuarios_usuario` VARCHAR(15) NOT NULL,
  `usuarios_empleados_id` INT NOT NULL,
  `catareas_id` INT(10) UNSIGNED NOT NULL,
  `catalmacen_id` INT(10) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`, `catproveedores_id`, `empleados_id`, `usuarios_usuario`, `usuarios_empleados_id`, `catalmacen_id`),
  CONSTRAINT `fk_entradas_catproveedores1`
    FOREIGN KEY (`catproveedores_id`)
    REFERENCES `bpmalmacen`.`catproveedores` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_entradas_empleados1`
    FOREIGN KEY (`empleados_id`)
    REFERENCES `bpmalmacen`.`empleados` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_entradas_catareas1`
    FOREIGN KEY (`catareas_id`)
    REFERENCES `bpmalmacen`.`catareas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_entradas_catalmacen1`
    FOREIGN KEY (`catalmacen_id`)
    REFERENCES `bpmalmacen`.`catalmacen` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `id_proveedor` ON `bpmalmacen`.`entradas` (`idproveedor` ASC);

CREATE INDEX `id_area` ON `bpmalmacen`.`entradas` (`idarea` ASC);

CREATE INDEX `id_recibio` ON `bpmalmacen`.`entradas` (`idrecibio` ASC);

CREATE INDEX `fk_entradas_catproveedores1_idx` ON `bpmalmacen`.`entradas` (`catproveedores_id` ASC);

CREATE INDEX `fk_entradas_empleados1_idx` ON `bpmalmacen`.`entradas` (`empleados_id` ASC);

CREATE INDEX `fk_entradas_catareas1_idx` ON `bpmalmacen`.`entradas` (`catareas_id` ASC);

CREATE INDEX `id_almacen` ON `bpmalmacen`.`entradas` (`idalmacen` ASC);

CREATE INDEX `fk_entradas_catalmacen1_idx` ON `bpmalmacen`.`entradas` (`catalmacen_id` ASC);


-- -----------------------------------------------------
-- Table `bpmalmacen`.`inventarios`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`inventarios` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`inventarios` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `tipo` VARCHAR(15) NOT NULL DEFAULT '',
  `fecha` DATE NOT NULL,
  `idautorizo` INT NOT NULL,
  `estatus` CHAR(1) NOT NULL DEFAULT '',
  `idalmacen` INT NOT NULL,
  `catalmacen_id` INT(10) UNSIGNED NOT NULL,
  `empleados_id` INT NOT NULL,
  PRIMARY KEY (`id`, `catalmacen_id`, `empleados_id`),
  CONSTRAINT `fk_inventarios_catalmacen1`
    FOREIGN KEY (`catalmacen_id`)
    REFERENCES `bpmalmacen`.`catalmacen` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_inventarios_empleados1`
    FOREIGN KEY (`empleados_id`)
    REFERENCES `bpmalmacen`.`empleados` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `id_almacen` ON `bpmalmacen`.`inventarios` (`idalmacen` ASC);

CREATE INDEX `id_autorizo` ON `bpmalmacen`.`inventarios` (`idautorizo` ASC);

CREATE INDEX `fk_inventarios_catalmacen1_idx` ON `bpmalmacen`.`inventarios` (`catalmacen_id` ASC);

CREATE INDEX `fk_inventarios_empleados1_idx` ON `bpmalmacen`.`inventarios` (`empleados_id` ASC);


-- -----------------------------------------------------
-- Table `bpmalmacen`.`maxmin`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`maxmin` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`maxmin` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `idarticulo` INT NOT NULL,
  `añoejercicio` VARCHAR(45) NOT NULL,
  `minimo` VARCHAR(45) NOT NULL,
  `maximo` VARCHAR(45) NOT NULL,
  `catarticulos_id` INT(10) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`, `catarticulos_id`),
  CONSTRAINT `fk_maxmin_catarticulos1`
    FOREIGN KEY (`catarticulos_id`)
    REFERENCES `bpmalmacen`.`catarticulos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `id_articulo` ON `bpmalmacen`.`maxmin` (`idarticulo` ASC);

CREATE INDEX `fk_maxmin_catarticulos1_idx` ON `bpmalmacen`.`maxmin` (`catarticulos_id` ASC);


-- -----------------------------------------------------
-- Table `bpmalmacen`.`salidas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`salidas` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`salidas` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `idarea` INT NOT NULL,
  `identrego` INT NOT NULL,
  `idrecibio` INT NOT NULL,
  `idautorizo` INT NOT NULL,
  `fecha` DATE NOT NULL,
  `observaciones` VARCHAR(45) NOT NULL DEFAULT '',
  `fechacaptura` DATE NOT NULL,
  `numsalida` INT NOT NULL,
  `idalmacen` INT NOT NULL,
  `tiposalida` VARCHAR(15) NOT NULL DEFAULT '',
  `catareas_id` INT(10) UNSIGNED NOT NULL,
  `empleados_id` INT NOT NULL,
  `empleados_id1` INT NOT NULL,
  `empleados_id2` INT NOT NULL,
  `catalmacen_id` INT(10) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`, `catareas_id`, `empleados_id`, `empleados_id1`, `empleados_id2`, `catalmacen_id`),
  CONSTRAINT `fk_salidas_catareas1`
    FOREIGN KEY (`catareas_id`)
    REFERENCES `bpmalmacen`.`catareas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_salidas_empleados1`
    FOREIGN KEY (`empleados_id`)
    REFERENCES `bpmalmacen`.`empleados` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_salidas_empleados2`
    FOREIGN KEY (`empleados_id1`)
    REFERENCES `bpmalmacen`.`empleados` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_salidas_empleados3`
    FOREIGN KEY (`empleados_id2`)
    REFERENCES `bpmalmacen`.`empleados` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_salidas_catalmacen1`
    FOREIGN KEY (`catalmacen_id`)
    REFERENCES `bpmalmacen`.`catalmacen` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `idarea` ON `bpmalmacen`.`salidas` (`idarea` ASC);

CREATE INDEX `identrego` ON `bpmalmacen`.`salidas` (`identrego` ASC);

CREATE INDEX `idrecibio` ON `bpmalmacen`.`salidas` (`idrecibio` ASC);

CREATE INDEX `idutorizo` ON `bpmalmacen`.`salidas` (`idautorizo` ASC);

CREATE INDEX `fk_salidas_catareas1_idx` ON `bpmalmacen`.`salidas` (`catareas_id` ASC);

CREATE INDEX `fk_salidas_empleados1_idx` ON `bpmalmacen`.`salidas` (`empleados_id` ASC);

CREATE INDEX `fk_salidas_empleados2_idx` ON `bpmalmacen`.`salidas` (`empleados_id1` ASC);

CREATE INDEX `fk_salidas_empleados3_idx` ON `bpmalmacen`.`salidas` (`empleados_id2` ASC);

CREATE INDEX `id_almacen` ON `bpmalmacen`.`salidas` (`idalmacen` ASC);

CREATE INDEX `fk_salidas_catalmacen1_idx` ON `bpmalmacen`.`salidas` (`catalmacen_id` ASC);


-- -----------------------------------------------------
-- Table `bpmalmacen`.`det_bajas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`det_bajas` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`det_bajas` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `idarticulo` INT NOT NULL,
  `cantidad` INT NOT NULL,
  `numlote` VARCHAR(45) NOT NULL DEFAULT '',
  `precio` INT NOT NULL,
  `iva` INT NOT NULL,
  `totalprecio` INT NOT NULL,
  `numrequisicion` VARCHAR(45) NOT NULL DEFAULT '',
  `nummarbete` VARCHAR(45) NOT NULL DEFAULT '',
  `numcontrol` VARCHAR(45) NOT NULL DEFAULT '',
  `caducidad` DATE NULL,
  `idbaja` INT NULL,
  `bajas_id` INT(10) UNSIGNED NOT NULL,
  `bajas_usuarios_usuario` VARCHAR(15) NOT NULL,
  `bajas_usuarios_catalmacen_id` INT(10) UNSIGNED NOT NULL,
  `bajas_catalmacen_id` INT(10) UNSIGNED NOT NULL,
  `bajas_empleados_id` INT NOT NULL,
  `bajas_empleados_id1` INT NOT NULL,
  `catarticulos_id` INT(10) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`, `bajas_id`, `bajas_usuarios_usuario`, `bajas_usuarios_catalmacen_id`, `bajas_catalmacen_id`, `bajas_empleados_id`, `bajas_empleados_id1`, `catarticulos_id`),
  CONSTRAINT `fk_detalle_bajas_bajas1`
    FOREIGN KEY (`bajas_id` , `bajas_catalmacen_id` , `bajas_empleados_id` , `bajas_empleados_id1`)
    REFERENCES `bpmalmacen`.`bajas` (`id` , `catalmacen_id` , `empleados_id` , `empleados_id1`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_bajas_catarticulos1`
    FOREIGN KEY (`catarticulos_id`)
    REFERENCES `bpmalmacen`.`catarticulos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `id_articulo` ON `bpmalmacen`.`det_bajas` (`idarticulo` ASC);

CREATE INDEX `id_baja` ON `bpmalmacen`.`det_bajas` (`idbaja` ASC);

CREATE INDEX `fk_detalle_bajas_bajas1_idx` ON `bpmalmacen`.`det_bajas` (`bajas_id` ASC, `bajas_usuarios_usuario` ASC, `bajas_usuarios_catalmacen_id` ASC, `bajas_catalmacen_id` ASC, `bajas_empleados_id` ASC, `bajas_empleados_id1` ASC);

CREATE INDEX `fk_detalle_bajas_catarticulos1_idx` ON `bpmalmacen`.`det_bajas` (`catarticulos_id` ASC);


-- -----------------------------------------------------
-- Table `bpmalmacen`.`det_entradas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`det_entradas` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`det_entradas` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `identrada` INT NOT NULL,
  `idproducto` INT NOT NULL,
  `cantidad` INT NOT NULL,
  `precio` INT NOT NULL,
  `iva` INT NOT NULL,
  `totalprecio` INT NOT NULL,
  `idmarca` INT NOT NULL,
  `idrequisicion` INT NOT NULL,
  `lote` VARCHAR(10) NOT NULL DEFAULT '',
  `caducidad` DATE NULL,
  `estado` VARCHAR(1) NOT NULL,
  `catarticulos_id` INT(10) UNSIGNED NOT NULL,
  `entradas_id` INT(10) UNSIGNED NOT NULL,
  `catmarcas_id` INT(10) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`, `catarticulos_id`, `entradas_id`, `catmarcas_id`),
  CONSTRAINT `fk_detalle_entradas_catarticulos1`
    FOREIGN KEY (`catarticulos_id`)
    REFERENCES `bpmalmacen`.`catarticulos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_entradas_entradas1`
    FOREIGN KEY (`entradas_id`)
    REFERENCES `bpmalmacen`.`entradas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_entradas_catmarcas1`
    FOREIGN KEY (`catmarcas_id`)
    REFERENCES `bpmalmacen`.`catmarcas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `id_producto` ON `bpmalmacen`.`det_entradas` (`idproducto` ASC);

CREATE INDEX `id_entrada` ON `bpmalmacen`.`det_entradas` (`identrada` ASC);

CREATE INDEX `fk_detalle_entradas_catarticulos1_idx` ON `bpmalmacen`.`det_entradas` (`catarticulos_id` ASC);

CREATE INDEX `fk_detalle_entradas_entradas1_idx` ON `bpmalmacen`.`det_entradas` (`entradas_id` ASC);

CREATE INDEX `id_marca` ON `bpmalmacen`.`det_entradas` (`idmarca` ASC);

CREATE INDEX `fk_detalle_entradas_catmarcas1_idx` ON `bpmalmacen`.`det_entradas` (`catmarcas_id` ASC);

CREATE INDEX `id_requisicion` ON `bpmalmacen`.`det_entradas` (`idrequisicion` ASC);


-- -----------------------------------------------------
-- Table `bpmalmacen`.`detalle_inventarios`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`detalle_inventarios` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`detalle_inventarios` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `idinventario` INT NOT NULL,
  `idarticulo` INT NOT NULL,
  `lote` VARCHAR(10) NOT NULL DEFAULT '',
  `cantidad` INT NOT NULL,
  `precio` INT NOT NULL,
  `iva` INT NOT NULL,
  `totalprecio` INT NOT NULL,
  `estado` VARCHAR(10) NOT NULL DEFAULT '',
  `idauditor` INT NOT NULL,
  `empleados_id` INT NOT NULL,
  `catarticulos_id` INT(10) UNSIGNED NOT NULL,
  `inventarios_id` INT(10) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`, `empleados_id`, `catarticulos_id`, `inventarios_id`),
  CONSTRAINT `fk_detalle_inventarios_empleados1`
    FOREIGN KEY (`empleados_id`)
    REFERENCES `bpmalmacen`.`empleados` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_inventarios_catarticulos1`
    FOREIGN KEY (`catarticulos_id`)
    REFERENCES `bpmalmacen`.`catarticulos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_inventarios_inventarios1`
    FOREIGN KEY (`inventarios_id`)
    REFERENCES `bpmalmacen`.`inventarios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `id_auditor` ON `bpmalmacen`.`detalle_inventarios` (`idauditor` ASC);

CREATE INDEX `id_articulo` ON `bpmalmacen`.`detalle_inventarios` (`idarticulo` ASC);

CREATE INDEX `fk_detalle_inventarios_empleados1_idx` ON `bpmalmacen`.`detalle_inventarios` (`empleados_id` ASC);

CREATE INDEX `fk_detalle_inventarios_catarticulos1_idx` ON `bpmalmacen`.`detalle_inventarios` (`catarticulos_id` ASC);

CREATE INDEX `id_inventario` ON `bpmalmacen`.`detalle_inventarios` (`idinventario` ASC);

CREATE INDEX `fk_detalle_inventarios_inventarios1_idx` ON `bpmalmacen`.`detalle_inventarios` (`inventarios_id` ASC);


-- -----------------------------------------------------
-- Table `bpmalmacen`.`requisiciones`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`requisiciones` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`requisiciones` (
  `id` INT NOT NULL,
  `fecha` DATE NOT NULL,
  `idarea` INT NOT NULL,
  `idsolicita` INT NOT NULL,
  `tipo` VARCHAR(15) NOT NULL,
  `catareas_id` INT(10) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`, `catareas_id`),
  CONSTRAINT `fk_requisiciones_catareas1`
    FOREIGN KEY (`catareas_id`)
    REFERENCES `bpmalmacen`.`catareas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `id_area` ON `bpmalmacen`.`requisiciones` (`idarea` ASC);

CREATE INDEX `id_solicita` ON `bpmalmacen`.`requisiciones` (`idsolicita` ASC);

CREATE INDEX `fk_requisiciones_catareas1_idx` ON `bpmalmacen`.`requisiciones` (`catareas_id` ASC);


-- -----------------------------------------------------
-- Table `bpmalmacen`.`det_salidas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`det_salidas` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`det_salidas` (
  `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `idsalida` INT NOT NULL,
  `idarticulo` INT NOT NULL,
  `idrequisicion` INT NOT NULL,
  `cantidad` INT NOT NULL,
  `precio` INT NOT NULL,
  `totalprecio` INT NOT NULL,
  `estado` VARCHAR(1) NOT NULL,
  `salidas_id` INT(10) UNSIGNED NOT NULL,
  `catarticulos_id` INT(10) UNSIGNED NOT NULL,
  `requisiciones_id` INT NOT NULL,
  PRIMARY KEY (`id`, `salidas_id`, `catarticulos_id`, `requisiciones_id`),
  CONSTRAINT `fk_detalle_salidas_salidas1`
    FOREIGN KEY (`salidas_id`)
    REFERENCES `bpmalmacen`.`salidas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_salidas_catarticulos1`
    FOREIGN KEY (`catarticulos_id`)
    REFERENCES `bpmalmacen`.`catarticulos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_salidas_requisiciones1`
    FOREIGN KEY (`requisiciones_id`)
    REFERENCES `bpmalmacen`.`requisiciones` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `id_salida` ON `bpmalmacen`.`det_salidas` (`idsalida` ASC);

CREATE INDEX `id_articulo` ON `bpmalmacen`.`det_salidas` (`idarticulo` ASC);

CREATE INDEX `id_requisicion` ON `bpmalmacen`.`det_salidas` (`idrequisicion` ASC);

CREATE INDEX `fk_detalle_salidas_salidas1_idx` ON `bpmalmacen`.`det_salidas` (`salidas_id` ASC);

CREATE INDEX `fk_detalle_salidas_catarticulos1_idx` ON `bpmalmacen`.`det_salidas` (`catarticulos_id` ASC);

CREATE INDEX `fk_detalle_salidas_requisiciones1_idx` ON `bpmalmacen`.`det_salidas` (`requisiciones_id` ASC);


-- -----------------------------------------------------
-- Table `bpmalmacen`.`det_requisiciones`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bpmalmacen`.`det_requisiciones` ;

CREATE TABLE IF NOT EXISTS `bpmalmacen`.`det_requisiciones` (
  `id` INT NOT NULL,
  `idrequisicion` INT NOT NULL,
  `idproducto` INT NOT NULL,
  `descripcion` VARCHAR(100) NULL,
  `requisiciones_id` INT NOT NULL,
  `catarticulos_id` INT(10) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`, `requisiciones_id`, `catarticulos_id`),
  CONSTRAINT `fk_detalle_requisiciones_requisiciones1`
    FOREIGN KEY (`requisiciones_id`)
    REFERENCES `bpmalmacen`.`requisiciones` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_requisiciones_catarticulos1`
    FOREIGN KEY (`catarticulos_id`)
    REFERENCES `bpmalmacen`.`catarticulos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `id_requisicion` ON `bpmalmacen`.`det_requisiciones` (`idrequisicion` ASC);

CREATE INDEX `id_producto` ON `bpmalmacen`.`det_requisiciones` (`idproducto` ASC);

CREATE INDEX `fk_detalle_requisiciones_requisiciones1_idx` ON `bpmalmacen`.`det_requisiciones` (`requisiciones_id` ASC);

CREATE INDEX `fk_detalle_requisiciones_catarticulos1_idx` ON `bpmalmacen`.`det_requisiciones` (`catarticulos_id` ASC);


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
