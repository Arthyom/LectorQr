CREATE DATABASE estudiantes ;
USE DATABASE estudiantes;

CREATE TABLE estudiantes (
	int 		nua 			not null primary key,
	varchar		nombre(30)		not null,
	varchar		evento(30)		not null,
	varchar		carrera(20)		not null,
	int 	 	apeidoPaterno	not null,
	int 		apeidoMaterno	not null,
	bool		asistencia		not null
);