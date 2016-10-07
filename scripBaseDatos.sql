DROP DATABASE IF EXISTS estudiantes;
CREATE DATABASE IF NOT EXISTS estudiantes ;
USE estudiantes;

CREATE TABLE IF NOT EXISTS estudiante (
	nua 			int         	not null primary key,
	nombre			varchar(30)		not null,
	evento			varchar(30)		not null,
	carrera     	varchar(20)		not null,
	apeidoPaterno	varchar(20)		not null,
 	apeidoMaterno	varchar(20)		not null,
	asistencia		bool			not null
);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (01, "estudiante1","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (02, "estudiante2","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (03, "estudiante3","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (04, "estudiante4","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (05, "estudiante5","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (06, "estudiante6","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (07, "estudiante7","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (08, "estudiante8","electroni" ,"prueba", "paterno1", "paterno2", false);


INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (09, "estudiante9","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (10, "estudiante10","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (11, "estudiante11","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (12, "estudiante12","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (13, "estudiante13","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (14, "estudiante14","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (15, "estudiante15","electroni" ,"prueba", "paterno1", "paterno2", false);



INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (16, "estudiante16","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (17, "estudiante17","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (18, "estudiante18","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (19, "estudiante19","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (20, "estudiante20","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (21, "estudiante21","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (22, "estudiante22","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (23, "estudiante23","electroni" ,"prueba", "paterno1", "paterno2", false);


INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (24, "estudiante24","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (25, "estudiante25","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (26, "estudiante26","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (27, "estudiante27","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (28, "estudiante28","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (29, "estudiante29","electroni" ,"prueba", "paterno1", "paterno2", false);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (30, "estudiante30","electroni" ,"prueba", "paterno1", "paterno2", false);



