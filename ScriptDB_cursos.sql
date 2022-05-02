-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema cursos
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema cursos
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `cursos` DEFAULT CHARACTER SET utf8 ;
-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
USE `cursos` ;

-- -----------------------------------------------------
-- Table `cursos`.`tb_cursos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cursos`.`tb_cursos` (
  `crs_codigo` INT(11) NOT NULL AUTO_INCREMENT,
  `crs_nome` VARCHAR(90) NOT NULL,
  `crs_categoria` VARCHAR(50) NOT NULL,
  `crc_carga_horaria` INT(11) NOT NULL,
  `crc_valor` DECIMAL(10,2) NOT NULL,
  `crc_ativo` BIT(1) NOT NULL,
  `crc_data_cadastro` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`crs_codigo`))
ENGINE = MyISAM
AUTO_INCREMENT = 10
DEFAULT CHARACTER SET = utf8;

USE `cursos` ;

-- -----------------------------------------------------
-- procedure SP_AtualizaCurso
-- -----------------------------------------------------

DELIMITER $$
USE `cursos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_AtualizaCurso`(
_crs_codigo int ,
_crc_carga_horaria int, 	
_crs_nome varchar(90),
_crc_valor decimal(10,2)
)
BEGIN
	update tb_cursos set crs_nome = _crs_nome, crc_valor = _crc_valor, crc_carga_horaria = _crc_carga_horaria where crs_codigo = _crs_codigo;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure SP_NovoCurso
-- -----------------------------------------------------

DELIMITER $$
USE `cursos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_NovoCurso`(
_crs_nome varchar(90),
_crs_categoria varchar(50),
_crc_carga_horaria int,
_crc_valor decimal(10,2)

)
begin

insert into tb_cursos( crs_nome, crs_categoria, crc_carga_horaria, crc_valor, crc_ativo, crc_data_cadastro)
values(_crs_nome, _crs_categoria, _crc_carga_horaria, _crc_valor, 1, default );
select * from tb_cursos where crs_codigo = (select @@identity);

end$$

DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
