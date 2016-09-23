CREATE DATABASE estudiantes ;
USE estudiantes;

CREATE TABLE estudiante (
	nua 			int         	not null primary key,
	nombre			varchar(30)		not null,
	evento			varchar(30)		not null,
	carrera     	varchar(20)		not null,
	apeidoPaterno	int 			not null,
 	apeidoMaterno	int				not null,
	asistencia		bool			not null
);

INSERT INTO estudiante ( nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia)
	VALUES (01, "estudiante1","electroni" ,"prueba", "paterno1", "paterno2", false);

