#dodavanje role
INSERT INTO db_pl.role (db_pl.role.id, db_pl.role.name) VALUE (1, "Admin");
INSERT INTO db_pl.role (db_pl.role.id, db_pl.role.name) VALUE (2, "Korisnik");

#dodavanje theme
INSERT INTO db_pl.theme (db_pl.theme.id, db_pl.theme.description) VALUE (1, "light");
INSERT INTO db_pl.theme (db_pl.theme.id, db_pl.theme.description) VALUE (2, "dark");
INSERT INTO db_pl.theme (db_pl.theme.id, db_pl.theme.description) VALUE (3, "nature");

#dodavanje seasons
INSERT INTO db_pl.seasons (db_pl.seasons.id, db_pl.seasons.year) VALUE (1, "2021/22");

#dodavanje position
INSERT INTO db_pl.position (db_pl.position.id, db_pl.position.description) VALUE (1, "Goalkeeper");
INSERT INTO db_pl.position (db_pl.position.id, db_pl.position.description) VALUE (2, "Defender");
INSERT INTO db_pl.position (db_pl.position.id, db_pl.position.description) VALUE (3, "Midfield");
INSERT INTO db_pl.position (db_pl.position.id, db_pl.position.description) VALUE (4, "Attacker");

#dodavanje formation
INSERT INTO db_pl.formation (db_pl.formation.id, db_pl.formation.description) VALUE (1, "3-6-1");
INSERT INTO db_pl.formation (db_pl.formation.id, db_pl.formation.description) VALUE (2, "3-5-2");
INSERT INTO db_pl.formation (db_pl.formation.id, db_pl.formation.description) VALUE (3, "3-4-3");
INSERT INTO db_pl.formation (db_pl.formation.id, db_pl.formation.description) VALUE (4, "4-5-1");
INSERT INTO db_pl.formation (db_pl.formation.id, db_pl.formation.description) VALUE (5, "4-4-2");
INSERT INTO db_pl.formation (db_pl.formation.id, db_pl.formation.description) VALUE (6, "4-3-3");
INSERT INTO db_pl.formation (db_pl.formation.id, db_pl.formation.description) VALUE (7, "5-4-1");
INSERT INTO db_pl.formation (db_pl.formation.id, db_pl.formation.description) VALUE (8, "5-3-2");
INSERT INTO db_pl.formation (db_pl.formation.id, db_pl.formation.description) VALUE (9, "5-2-3");

#dodavanje city
INSERT INTO db_pl.city (db_pl.city.id, db_pl.city.name) VALUE (1, "London");
INSERT INTO db_pl.city (db_pl.city.id, db_pl.city.name) VALUE (2, "Liverpool");

#dodavanje account
INSERT INTO db_pl.account (db_pl.account.username, db_pl.account.password, db_pl.account.fk_theme_id, db_pl.account.fk_role_id, db_pl.account.status) VALUE ("ogi", "pass", 3, 1, 1);
INSERT INTO db_pl.account (db_pl.account.username, db_pl.account.password, db_pl.account.fk_theme_id, db_pl.account.fk_role_id, db_pl.account.status) VALUE ("ogi2", "pass2", 1, 2, 1);

#dodavaje football_club
INSERT INTO db_pl.football_club (db_pl.football_club.id, db_pl.football_club.founded, db_pl.football_club.owner, db_pl.football_club.name, db_pl.football_club.nick_name, db_pl.football_club.fk_city_id_for_fc, db_pl.football_club.image_name, db_pl.football_club.tshirt_image_name) VALUE (1, '2022-11-01', "Stan", "Arsenal", "Gunners", 1, "arsenalFC.png", "arsenalDres.png");
INSERT INTO db_pl.football_club (db_pl.football_club.id, db_pl.football_club.founded, db_pl.football_club.owner, db_pl.football_club.name, db_pl.football_club.nick_name, db_pl.football_club.fk_city_id_for_fc, db_pl.football_club.image_name, db_pl.football_club.tshirt_image_name) VALUE (2, '2022-09-01', "Fans", "Liverpool", "Reds", 2, "liverpoolFC.png", "dresLiverpool.png");

#dodavanje football_club_has_seasone
#INSERT INTO db_pl.football_club_has_seasone (db_pl.football_club_has_seasone.football_club_id, pl_db.football_club_has_seasone.seasone_id, pl_db.football_club_has_seaone.table_position) VALUES (1, 1, 1);
#INSERT INTO db_pl.football_club_has_seasone (db_pl.football_club_has_seasone.football_club_id, pl_db.football_club_has_seasone.seasone_id, pl_db.football_club_has_seaone.table_position) VALUES (2, 1, 2);

#dodavanje country 
INSERT INTO db_pl.country (db_pl.country.id, db_pl.country.name, db_pl.country.image_name) VALUES (1, "England", "flagOfEngland.jpg");
INSERT INTO db_pl.country (db_pl.country.id, db_pl.country.name, db_pl.country.image_name) VALUES (2, "Scotland", "flagOfScotland.jpg");
INSERT INTO db_pl.country (db_pl.country.id, db_pl.country.name, db_pl.country.image_name) VALUES (3, "Brasil", "flagOfBrasil.jpg");
INSERT INTO db_pl.country (db_pl.country.id, db_pl.country.name, db_pl.country.image_name) VALUES (4, "Portugal", "flagOfPortugal.jpg");

#dodavanje igraca
#tim arsenal
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (7, 4, "Saka", '2022-05-03', 1, 1, 1, "saka.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (1, 1, "Ramsdel", '2022-05-03', 1, 1, 1, "ramsdel.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (2, 2, "Tierny", '2022-05-03', 1, 2, 1, "tierny.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (3, 2, "White", '2022-05-03', 1, 1, 1, "white.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (4, 2, "Gabriel", '2022-05-03', 1, 3, 1, "gabriel.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (5, 3, "Partey", '2022-05-03', 1, 4, 1, "partey.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (6, 3, "Odegard", '2022-05-03', 1, 2, 1, "odegard.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (8, 3, "Rowe", '2022-05-03', 1, 1, 1, "rowe.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (9, 4, "Martineli", '2022-05-03', 1, 1, 1, "martineli.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (10, 4, "Jesus", '2022-05-03', 1, 1, 1, "jesus.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (11, 2, "Saliba", '2022-05-03', 1, 1, 1, "saliba.png");

#tim liverpool
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (7, 4, "Salah", '2022-05-03', 1, 1, 2, "salah.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (1, 1, "Alison", '2022-05-03', 1, 1, 2, "alison.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (2, 2, "Virgil van Dijk", '2022-05-03', 1, 2, 2, "virgilvandijk.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (3, 2, "Gomez", '2022-05-03', 1, 1, 2, "gomez.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (4, 2, "Robertson", '2022-05-03', 1, 3, 2, "robertson.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (5, 3, "Ramsey", '2022-05-03', 1, 4, 2, "ramsey.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (6, 3, "Milner", '2022-05-03', 1, 2, 2, "milner.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (8, 3, "Chambrlain", '2022-05-03', 1, 1, 2, "chamberlain.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (9, 4, "Henderson", '2022-05-03', 1, 1, 2, "henderson.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (10, 4, "Jota", '2022-05-03', 1, 1, 2, "jota.png");
INSERT INTO db_pl.player (db_pl.player.number, db_pl.player.fk_position_id, db_pl.player.name, db_pl.player.date_birth, db_pl.player.status, db_pl.player.fk_country_id_player, db_pl.player.fk_football_club_id, db_pl.player.image_name) VALUES (11, 4, "Nunez", '2022-05-03', 1, 1, 2, "nunez.png");
