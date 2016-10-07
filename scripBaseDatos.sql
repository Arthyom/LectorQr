DROP DATABASE IF EXISTS estudiantes;
CREATE DATABASE IF NOT EXISTS estudiantes ;
USE estudiantes;

CREATE TABLE IF NOT EXISTS registro (
	nua int,
	nombre varchar(70)
);

CREATE TABLE IF NOT EXISTS estudiante (
	nua 			int         	not null primary key,
	nombre			varchar(30)		not null,
	evento			varchar(30)		not null,
	carrera     	varchar(20)		not null,
	apeidoPaterno	varchar(20)		not null,
 	apeidoMaterno	varchar(20)		not null,
	asistencia		bool			not null
);

