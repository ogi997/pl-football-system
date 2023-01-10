-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema db_pl
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema db_pl
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `db_pl` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci ;
USE `db_pl` ;

-- -----------------------------------------------------
-- Table `db_pl`.`theme`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_pl`.`theme` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `description` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pl`.`role`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_pl`.`role` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pl`.`account`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_pl`.`account` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(255) NOT NULL,
  `password` VARCHAR(255) NOT NULL,
  `fk_theme_id` INT NOT NULL,
  `fk_role_id` INT NOT NULL,
  `status` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_theme_id_idx` (`fk_theme_id` ASC) VISIBLE,
  INDEX `fk_role_id_idx` (`fk_role_id` ASC) VISIBLE,
  CONSTRAINT `fk_theme_id`
    FOREIGN KEY (`fk_theme_id`)
    REFERENCES `db_pl`.`theme` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_role_id`
    FOREIGN KEY (`fk_role_id`)
    REFERENCES `db_pl`.`role` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pl`.`city`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_pl`.`city` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pl`.`country`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_pl`.`country` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NOT NULL,
  `image_name` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pl`.`position`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_pl`.`position` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `description` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pl`.`football_club`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_pl`.`football_club` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `founded` DATE NOT NULL,
  `owner` VARCHAR(255) NOT NULL,
  `name` VARCHAR(255) NOT NULL,
  `nick_name` VARCHAR(255) NOT NULL,
  `fk_city_id_for_fc` INT NOT NULL,
  `image_name` VARCHAR(255) NOT NULL,
  `tshirt_image_name` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `city_id_idx` (`fk_city_id_for_fc` ASC) VISIBLE,
  CONSTRAINT `fk_city_id_for_fc`
    FOREIGN KEY (`fk_city_id_for_fc`)
    REFERENCES `db_pl`.`city` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pl`.`player`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_pl`.`player` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `number` INT NOT NULL,
  `fk_position_id` INT NOT NULL,
  `name` VARCHAR(255) NOT NULL,
  `date_birth` DATE NOT NULL,
  `status` INT NOT NULL,
  `fk_country_id_player` INT NOT NULL,
  `fk_football_club_id` INT NOT NULL,
  `image_name` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `position_id_idx` (`fk_position_id` ASC) VISIBLE,
  INDEX `country_id_player_idx` (`fk_country_id_player` ASC) VISIBLE,
  INDEX `fk_football_club_id_idx` (`fk_football_club_id` ASC) VISIBLE,
  CONSTRAINT `fk_position_id`
    FOREIGN KEY (`fk_position_id`)
    REFERENCES `db_pl`.`position` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_country_id_player`
    FOREIGN KEY (`fk_country_id_player`)
    REFERENCES `db_pl`.`country` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_football_club_id`
    FOREIGN KEY (`fk_football_club_id`)
    REFERENCES `db_pl`.`football_club` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pl`.`seasons`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_pl`.`seasons` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `year` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pl`.`match`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_pl`.`match` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `goals_scored_home_fc` INT NOT NULL,
  `goals_received_away_fc` INT NOT NULL,
  `seasone_id_for_match` INT NOT NULL,
  `date` DATE NOT NULL,
  `fk_home_football_club_id` INT NOT NULL,
  `fk_away_football_club_id` INT NOT NULL,
  INDEX `idSEASONE_idx` (`seasone_id_for_match` ASC) VISIBLE,
  INDEX `fk_home_football_club_id_idx` (`fk_home_football_club_id` ASC) VISIBLE,
  INDEX `fk_away_football_club_id_idx` (`fk_away_football_club_id` ASC) VISIBLE,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_seasone_id_for_match`
    FOREIGN KEY (`seasone_id_for_match`)
    REFERENCES `db_pl`.`seasons` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_home_football_club_id`
    FOREIGN KEY (`fk_home_football_club_id`)
    REFERENCES `db_pl`.`football_club` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_away_football_club_id`
    FOREIGN KEY (`fk_away_football_club_id`)
    REFERENCES `db_pl`.`football_club` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pl`.`football_club_has_seasone`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_pl`.`football_club_has_seasone` (
  `football_club_id` INT NOT NULL,
  `seasone_id` INT NOT NULL,
  `table_position` INT NOT NULL,
  INDEX `fk_football_club_has_seasone_seasone1_idx` (`seasone_id` ASC) VISIBLE,
  INDEX `fk_football_club_has_seasone_football_club1_idx` (`football_club_id` ASC) VISIBLE,
  PRIMARY KEY (`football_club_id`, `seasone_id`),
  CONSTRAINT `fk_football_club_has_seasone_football_club1`
    FOREIGN KEY (`football_club_id`)
    REFERENCES `db_pl`.`football_club` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_football_club_has_seasone_seasone1`
    FOREIGN KEY (`seasone_id`)
    REFERENCES `db_pl`.`seasons` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pl`.`formation`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_pl`.`formation` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `description` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pl`.`first_team`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_pl`.`first_team` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `fk_match_id` INT NOT NULL,
  `fk_fc_id` INT NOT NULL,
  `fk_player_id` INT NOT NULL,
  `fk_formation_id` INT NOT NULL,
  `player_position` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_match_id_idx` (`fk_match_id` ASC) VISIBLE,
  INDEX `fk_football_club_id_idx` (`fk_fc_id` ASC) VISIBLE,
  INDEX `fk_player_id_idx` (`fk_player_id` ASC) VISIBLE,
  INDEX `fk_formation_id_idx` (`fk_formation_id` ASC) VISIBLE,
  CONSTRAINT `fk_match_id`
    FOREIGN KEY (`fk_match_id`)
    REFERENCES `db_pl`.`match` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fc_id`
    FOREIGN KEY (`fk_fc_id`)
    REFERENCES `db_pl`.`football_club` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_player_id`
    FOREIGN KEY (`fk_player_id`)
    REFERENCES `db_pl`.`player` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_formation_id`
    FOREIGN KEY (`fk_formation_id`)
    REFERENCES `db_pl`.`formation` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `db_pl`;

DELIMITER $$
USE `db_pl`$$
CREATE DEFINER = CURRENT_USER TRIGGER `db_pl`.`match_AFTER_INSERT` AFTER INSERT ON `match` FOR EACH ROW
BEGIN

END
$$


DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
