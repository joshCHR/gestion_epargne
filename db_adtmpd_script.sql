use master 
go 
if exists(select*from sys.databases where name='db_adtmpd')
				drop database db_adtmpd
go
create database db_adtmpd
go 
use db_adtmpd
go
----------------creation de la table login--------
create table t_login
(
	UserName nvarchar (100),
	psword nvarchar(100)
	constraint pk_login primary key (UserName)
)
go
	insert into t_login
		(UserName,psword)
	values 
		('josue',12345),
		('josh',112233)
go

create procedure affiche_login
as 
	select top 2
		'josue' as '12345',
		'josh' as '112233'
	from t_login
		order by UserName asc
go
create procedure enregistrer_login 
	@UserName nvarchar(100),
	@psword nvarchar(100)
as	
	merge t_login
	using (select @UserName as nom)as x_nom
	on(x_nom.nom=t_login.UserName)
	when matched then
		update set 
			psword=@psword
	when not matched then
		insert
			(UserName,psword)
		values
			(@UserName,@psword);
			
go
create procedure supprimer_login
@UserName nvarchar(100)
as
		delete from t_login
		where UserName=@UserName
go 
create procedure recherche_ligin
@UserName nvarchar(100)
as 
	select top 2
			UserName as 'Nom',
			psword as 'Mot de Passe'
	from t_login
		order by UserName asc
go
-----------------fin login
---------------------------------creation de table User----------------
create table t_user
(
	id_user nvarchar(100),
	nom nvarchar(100),
	postnom nvarchar(100),
	levels nvarchar(100)
	constraint pk_user primary key (id_user)
)
go
		insert into t_user
			(id_user,nom,postnom,levels)
		values
			('josh','josue','MATANDIKO','sec'),
			('sifgrac','grace','Sifa','comptable')
go
create procedure afficher_user
as
	select top 2
			id_user as'ID',
			nom as 'Nom Utilisateur',
			postnom as 'Postnom',
			levels as 'Niveau'
	from t_user
		order by id_user asc
go 
create procedure enregistrer_user
@id_user nvarchar(100),
@nom nvarchar (100),
@postnom nvarchar(100),
@levels nvarchar(100)
as	
		merge t_user
		using(select @id_user as u) as x_user
		on(x_user.u=t_user.id_user)
		when matched then
			update set
				@nom=nom,
				@postnom = postnom,
				@levels = levels
		when not matched then
				insert 
					(id_user,nom,postnom,levels)
				values 
					(@id_user,@nom,@postnom,@levels);
go
create procedure supprimer_user
@id_user nvarchar(100)
as	
	delete from t_user
		where id_user=@id_user
go
------------------create table Membre-----------------------
create table t_membre
(
	matricule nvarchar (50),
	nom nvarchar (50),
	postnom nvarchar (50),
	adresse nvarchar(50),
	phone nvarchar(50),
	sexe nvarchar(50),
	lieuNaiss nvarchar(50),
	dateNaiss date
	--photo image
	constraint pk_membre primary key (matricule)
)
go
		insert into t_membre
					(matricule, nom,postnom,adresse,phone,sexe,lieuNaiss,dateNaiss)
		values 
					('11wwe3','josue','MATANDIKO','GOMA',0975778463,'M','Goma','12/10/2000'),
					('12wwe3','moses','KATORO','GOMA',0985574556,'M','Goma','03/11/2004'),
					('13wwe3','HENRI','MASUKU','GOMA',0975778463,'M','Goma','12/10/2000'),
					('14wwe3','tresor','KITWANDA','GOMA',0975778463,'M','Goma','12/10/2000'),
					('15wwe3','eunice','bandu','GOMA',09854735,'M','Goma','12/10/2000'),
					('16wwe3','josue','MATANDIKO','GOMA',0975778463,'M','Goma','12/10/2000'),
					('72wwe3','josue','MATANDIKO','GOMA',0975778463,'M','Goma','12/10/2000'),
					('18wwe3','josue','MATANDIKO','GOMA',0975778463,'M','Goma','12/10/2000'),
					('19wwe3','josue','MATANDIKO','GOMA',0975778463,'M','Goma','12/10/2000'),
					('132wwe3','josue','MATANDIKO','GOMA',0975778463,'M','Goma','12/10/2000')
go

create procedure affiche_membre
as 
		select top  20
			matricule,
			nom ,
			postnom ,
			adresse ,
			phone ,
			sexe ,
			lieuNaiss,
			dateNaiss 
		from t_membre
		order by nom asc
go
create procedure enregistrer_mambre
@matricule nvarchar (50),
@nom nvarchar (50),
@postnom nvarchar (50),
@adresse nvarchar (50),
@phone nvarchar (50),
@sexe nvarchar (50),
@lieuNaiss nvarchar (50),
@dateNaiss  date
--@photo image
as 
		merge t_membre
		using(select @matricule as mat) as x_mat
		on(x_mat.mat=t_membre.matricule)
		when matched then
		update set
			@nom = nom,
			@postnom = postnom,
			@adresse = adresse,
			@phone = phone,
			@sexe = sexe,
			@lieuNaiss = lieuNaiss,
			@dateNaiss = dateNaiss
			--@photo = photo
		when not matched then
			insert 
				(matricule,nom,postnom,adresse,phone,sexe,lieuNaiss,dateNaiss)--photo)
			values
			(@matricule,@nom,@postnom,@adresse,@phone,@sexe,@lieuNaiss,@dateNaiss);--@photo);
go
create procedure supprimer_membre
@matricule nvarchar(50)
as 
		delete from t_membre
		where matricule = @matricule
go
create procedure recherche_membre_parnom
@matricule nvarchar(50),
@nom nvarchar(50)

as
			select top 20
		
			matricule,
			nom ,
			postnom ,
			adresse ,
			phone ,
			sexe ,
			lieuNaiss,
			dateNaiss 
		from t_membre
		where matricule like'%'+matricule+'%' and nom like'%'+@nom+'%'
		
		select * from t_membre
		exec supprimer_membre  @matricule ='15wwe3'