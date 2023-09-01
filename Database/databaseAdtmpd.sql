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
	select UserName
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
	poste nvarchar(50),
	levels nvarchar(100) default '0',
	statut nvarchar(10) default 'on',
	user_pass nvarchar(100) default '12345'
	constraint pk_user primary key (id_user)
)
go
		insert into t_user
			(id_user,nom,postnom,poste)
		values
			('josh','MATANDIKO','KALAMO','Super-Admin')
go
create procedure afficher_user
as
	select top 5
			id_user,
			nom,
			postnom,
			poste,
			levels,
			statut
	from t_user
		order by id_user asc
go 
create procedure rechercher_user
@search nvarchar(50)
as
	select 
		id_user,
		nom,
		postnom,
		poste,
		levels,
		statut
	from t_user
	where nom  like '%'+@search+'%' or postnom  like '%'+@search+'%' or id_user like '%'+@search+'%' 
go
create procedure enregistrer_user
@id_user nvarchar(100),
@nom nvarchar (100),
@postnom nvarchar(100),
@poste nvarchar(50),
@levels nvarchar(100),
@statut nvarchar(50)
as	
		merge t_user
		using(select @id_user as u) as x_user
		on(x_user.u=t_user.id_user)
		when matched then
		update set
		nom = @nom,
		postnom = @postnom,
		poste = @poste,
		levels = @levels,
		statut = @statut
		when not matched then
				insert 
					(id_user,nom,postnom,poste,levels,statut)
				values 
					(@id_user,@nom,@postnom,@poste,@levels,@statut);
go
create procedure supprimer_user
@id_user nvarchar(100)
as	
	delete from t_user
		where id_user=@id_user
go
create procedure select_user
@username nvarchar(50)
as
	select 
		id_user,
		nom +' '+postnom as 'noms',
		poste,
		levels,
		statut 
	from t_user where id_user = @username
go
create procedure se_connecter
@id_user nvarchar(100),
@user_password nvarchar(100)
as
begin
	set nocount on;
	declare @result int;
	select @result = count(*) from t_user
	where id_user=@id_user and user_pass=@user_password;

	select @result as result
end
go
create procedure user_exist
@id_user nvarchar(100)
as
begin
	set nocount on;
	declare @result int;
	select @result = count(*) from t_user
	where id_user=@id_user;

	select @result as result
end
go
create procedure names_exist
@nom nvarchar(100),
@postnom nvarchar(100)
as
begin
	set nocount on;
	declare @result int;
	select @result = count(*) from t_user
	where nom=@nom and postnom=@postnom;

	select @result as result
end
go
create procedure user_affected
@id_user nvarchar(100),
@poste nvarchar(100)
as
begin
	set nocount on;
	declare @result int;
	select @result = count(*) from t_user
	where id_user=@id_user and poste=@poste;

	select @result as result
end
go
create procedure rechercher_noms_user_par_id
@id_user nvarchar(50)
as
    select nom +' '+postnom as 'noms' from t_user
    where id_user = @id_user
go
create procedure select_level
@id_user nvarchar(50)
as
    select levels from t_user
    where id_user = @id_user
go
------------------------------Fin user-------------------
--------------- Gestion Type Membres ------------------------------------------------
create table t_type_membre(
    id_type_membre nvarchar(50),
    designation nvarchar(50),
    constraint pk_id_type_membre primary key (id_type_membre)   
)
go
insert into t_type_membre(id_type_membre,designation) values('TM001','Membre Standard')
go
-------------- Procedure pour verifier si la designation existe deja ----------------------
create procedure designation_existe
@designation nvarchar(50)
as
begin
	set nocount on;
	declare @result int;
	select @result = count(*) from t_type_membre 
	where designation=@designation;

	select @result as result
end
--------------- Fin Procedure pour verifier si le malade existe deja ----------------------
go
create procedure enregistrer_type_membre
    @id_type_membre nvarchar(50),
    @designation nvarchar(50)
    as
            merge into t_type_membre
        using (select @id_type_membre as x_id) as x_source
        on(x_source.x_id = t_type_membre.id_type_membre)
        when matched then
            update set
				id_type_membre = @id_type_membre,
                designation = @designation
        when not matched then
            insert (id_type_membre,designation)
            values(@id_type_membre,@designation);
go
create procedure afficher_type_membre
as
    select top 10
        id_type_membre,
        designation
     
    from t_type_membre
        order by
            id_type_membre desc
go
create procedure supprimer_type_membre
@id_type_membre nvarchar(50)
as
    delete from t_type_membre
        where
            id_type_membre = @id_type_membre
go
-------------- Charger noms membres dans un combo box -------------------------------
create procedure charger_types_membres
as
    select id_type_membre,designation from 
        t_type_membre
        order by
            id_type_membre desc
-------------- Fin Charger noms malades dans un combo box -------------------------------
go
create procedure rechercher_id_par_designation
@designation nvarchar(50)
as
    select id_type_membre from t_type_membre 
    where designation = @designation
go
create procedure rechercher_type_membres
@designation nvarchar(50)
as
    select 
		id_type_membre,
        designation
	from 
		t_type_membre
    where 
		t_type_membre.designation like '%'+@designation+'%'
go


------------------create table Membre-----------------------
create table t_membre
(
	matricule nvarchar (100),
	nom nvarchar (100),
	postnom nvarchar (100),
	adresse nvarchar(100),
	phone nvarchar(100),
	sexe nvarchar(50),
	lieuNaiss nvarchar(50),
	dateNaiss date,
	ref_type nvarchar(50)
	constraint pk_membre primary key (matricule),
	constraint fk_type_membre foreign key (ref_type) references t_type_membre(id_type_membre)
)			
go
insert into t_membre values('21IGGJ119450','KOKO','KATORO','MABANGA-NORD','+243995010362','HOMME','GOMA','01/01/2001','TM001')
go
create procedure afficher_membre
as 
		select top 15 
			matricule,
			ref_type,
			nom,
			postnom,
			adresse,
			phone,
			sexe,
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
@dateNaiss  date,
@ref_type nvarchar(50)
as 
		merge t_membre
		using(select @matricule as mat) as x_mat
		on(x_mat.mat=t_membre.matricule)
		when matched then
		update set
			nom = @nom,
			postnom = @postnom,
			adresse = @adresse,
			phone = @phone,
			sexe = @sexe,
			lieuNaiss = @lieuNaiss,
			dateNaiss = @dateNaiss,
			ref_type= @ref_type
		when not matched then
			insert 
				(matricule,nom,postnom,adresse,phone,sexe,lieuNaiss,dateNaiss,ref_type)
			values
			(@matricule,@nom,@postnom,@adresse,@phone,@sexe,@lieuNaiss,@dateNaiss,@ref_type);
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
			select top 15
			matricule,
			ref_type,
			nom,
			postnom,
			adresse,
			phone,
			sexe,
			lieuNaiss,
			dateNaiss
		from t_membre
		where matricule like'%'+@matricule+'%' or nom like'%'+@nom+'%'
go
create procedure charger_membres
as
	select 
		matricule,nom +' '+postnom as 'noms' 
	from t_membre
	order by matricule asc
go
-----------------------------------fin membre------------------------------

------------------------------------------table pret-------------------------

  create table t_Pret
(
	id_pret int identity,
	membre nvarchar(100),
	secteur nvarchar(100),
	versement money,
	date_pret date,
	id_user nvarchar(100),
	constraint pk_client primary key(id_pret),
	constraint fk_membre foreign key(membre) references t_membre(matricule),
	--constraint fk_user foreign key(id_user) references t_user(id_user)
)

go
create procedure enregistrer_pret
@id_pret int,
@membre nvarchar(100),
@secteur nvarchar(100),
@versement money,
@date_pret date,
@id_user nvarchar(100)

as
	merge t_Pret
	using (select @id_pret as x_id) as x_source
	on(x_source.x_id=t_Pret.id_pret )
	when matched then
		update set
			membre = @membre,
			secteur = @secteur,
			versement = @versement,
			date_pret = @date_pret,
			id_user = @id_user 
	when not matched then
		insert 
			(membre,secteur ,versement,date_pret,id_user)
		values
			(@membre ,@secteur ,@versement,@date_pret,@id_user);
go
create procedure modifier_pret
@id_pret int ,
@membre nvarchar(100),
@secteur nvarchar(100),
@versement money,
@date_pret date,
@id_user nvarchar(100)
    as
            update t_Pret set
           membre = @membre,
			secteur = @secteur,
			versement = @versement,
			date_pret = @date_pret,
			id_user = @id_user 
        where id_pret = @id_pret
go
create procedure supprimer_pret
@id_pret int
as
			delete from t_Pret
		where
			id_pret = @id_pret 
			
go
create procedure rechercher_pret
@search nvarchar(100)
as
	select top 20
		id_pret,
		t_membre.nom +' '+postnom as 'membre',
		secteur ,
		versement, 
		date_pret,
		id_user
	from 
		t_Pret
			inner join t_membre on t_Pret.membre=t_membre.matricule
			where
			id_pret like '%'+@search +'%'  or nom like '%'+@search +'%' or secteur like '%'+@search+'%'
go
create procedure afficher_pret
as
			select top 50
				id_pret,
				 t_membre.nom +' '+postnom as 'membre',
				 secteur ,
				 versement, 
				 date_pret,
				 id_user
			from t_Pret
			inner join t_membre on t_Pret.membre=t_membre.matricule
			--inner join t_user on t_Pret.id_user=t_user.id_user
		order by id_pret asc
go
create procedure charger_pret
as
	select id_pret, t_membre.nom +' '+postnom as 'membre'
	from t_Pret
			inner join t_membre on t_Pret.membre=t_membre.matricule
	order by id_pret asc
go
-----------------------------------------------teble rembousement-------------------------
create table t_remboursement
(
	id_remb int identity,
	dateRemb date,
	montantRemb money,
	id_pret int,
	id_user nvarchar(100),
	constraint pk_remboursement primary key(id_remb ),
	
	--constraint fk_usr foreign key (id_user) references t_user(id_user)
	constraint fk_pret foreign key (id_pret) references t_pret(id_pret)
)
go

create procedure afficher_remboursement
as
				select top 50
				id_remb ,
				t_membre.nom +' '+t_membre.postnom as 'membre',
				dateRemb ,
				montantRemb, 
				t_remboursement.id_user as 'user'
			from t_remboursement
		
			--inner join t_user on t_remboursement.id_user=t_user.id_user,
			inner join t_pret on t_remboursement.id_pret = t_pret.id_pret
			inner join t_membre on t_Pret.membre=t_membre.matricule
		order by id_remb asc
go
create procedure enregistrer_remboursement 
@id_remb int,
@id_pret int,
@dateRemb date,
@montantRemb money,
@id_user nvarchar(100)
as
	merge t_remboursement
	using (select @id_remb as x_id) as x_source
	on(x_source.x_id=  t_remboursement.id_remb )
	when matched then
		update set
			id_pret = @id_pret,
			dateRemb = @dateRemb ,
			montantRemb=@montantRemb,
			id_user=@id_user
	when not matched then
		insert 
			(id_pret,dateRemb ,montantRemb, id_user)
		values
			(@id_pret,@dateRemb ,@montantRemb, @id_user );
go
create procedure supprimer_remboursement
@id_remb int
as
	delete from t_remboursement
		where
			id_remb= @id_remb
			
go
create procedure rechercher_remboursement
@search nvarchar(100)
as
	select top 50
				id_remb ,
				t_membre.nom +' '+t_membre.postnom as 'membre',
				dateRemb ,
				montantRemb, 
				t_remboursement.id_user as 'user'
			from t_remboursement
		
			--inner join t_user on t_remboursement.id_user=t_user.id_user,
			inner join t_pret on t_remboursement.id_pret = t_pret.id_pret
			inner join t_membre on t_Pret.membre=t_membre.matricule
		
			where
			id_remb like '%'+@search +'%' or t_membre.nom  like '%'+@search +'%'  or montantRemb like '%'+@search +'%' 
			or t_membre.postnom like '%'+@search+'%'
go

---------------------------------------------Fin remboursement--------------
--------------- Gestion Restitution ------------------------------------------------
create table t_restituer(
    id_restituer int identity(1,1),
    ref_pret int,
	ref_rembourser int,
	interets money,
	date_rest date,
    constraint pk_id_restituer primary key (id_restituer),
    constraint fk_ref_rembourser foreign key (ref_rembourser) references 
	t_remboursement(id_remb) on delete cascade on update cascade,
	constraint fk_ref_pret foreign key (ref_pret) references 
	t_pret(id_pret) on delete cascade on update cascade
)
go
create procedure enregistrer_restituer
	@ref_pret int,
	@ref_rembourser int,
	@interets money,
	@date_rest date
    as
            insert into t_restituer (ref_pret,ref_rembourser,date_rest,interets)
            values(@ref_pret,@ref_rembourser,@date_rest,@interets);

go
create procedure modifier_restituer
	@id_restituer int,
	@ref_pret int,
	@ref_rembourser int,
	@date_rest date,
	
	@interets money
    as
            update  t_restituer set 
			ref_pret=@ref_pret,
			ref_rembourser=@ref_rembourser,
			date_rest=@date_rest,
		
			interets=@interets
            where id_restituer = @id_restituer
go
create procedure afficher_restituer
as
    select top 20
		id_restituer,
        ref_pret,
		ref_rembourser,
		date_rest,
	
		interets
    from t_restituer
        order by
            id_restituer desc
go
create procedure supprimer_restituer
@id_restituer int
as
    delete from t_restituer
        where
            id_restituer = @id_restituer
go
create procedure rechercher_restituer
@search nvarchar(50)
as
    select 
		id_restituer,
        ref_pret,
		ref_rembourser,
		date_rest,

		interets
	from 
		t_restituer
    where 
		id_restituer like '%'+@search+'%' or ref_pret like '%'+@search+'%' or
		ref_rembourser like '%'+@search+'%' or date_rest like '%'+@search+'%' 
	
go

-----------------------------------------table adhesion-------------------
create table t_adhesion
(
	idAhesion int identity(1,1), 
	matriculeMembre nvarchar(100),
	dateAhesion date,
	montantAdhesion money,
	motifAhesion nvarchar(100),
	statutAdhesion nvarchar(100),
	constraint pk_idAdhesion primary key(idAhesion),
	constraint fk_idMembre foreign key(matriculeMembre) references t_membre(matricule)
)
go
/* procedure afficher adhesion*/
create procedure afficher_adhesion 
as 
				select top 20 
		idAhesion,
		t_membre.nom + ' '+postnom as 'noms',
		dateAhesion,
		montantAdhesion ,
		motifAhesion,
		statutAdhesion
		
		from t_Adhesion
		inner join t_membre on t_adhesion.matriculeMembre=t_membre.matricule
		order by matriculeMembre asc

go


create procedure enregistrer_adhesion
		@matriculeMembre nvarchar(100),
		@dateAhesion date,
		@montantAdhesion money,
		@motifAhesion nvarchar(100),
		@statutAdhesion nvarchar(100)

as
		insert into t_adhesion
			(matriculeMembre, dateAhesion,montantAdhesion,motifAhesion, statutAdhesion)
		values
			(@matriculeMembre, @dateAhesion, @montantAdhesion, @motifAhesion, @statutAdhesion);
go
create procedure modifier_adhesion
		@idAhesion int,
		@matriculeMembre nvarchar(100),
		@dateAhesion date,
		@montantAdhesion money,
		@motifAhesion nvarchar(100),
		@statutAdhesion nvarchar(100)
as
		update t_adhesion set
		matriculeMembre = @matriculeMembre,
		dateAhesion = @dateAhesion,
		montantAdhesion = @montantAdhesion,
		motifAhesion = @motifAhesion,
		statutAdhesion = @statutAdhesion
	where idAhesion = @idAhesion
go
/* procedure rechercher adhesion*/
create procedure rechercher_adhesion
@search nvarchar(50)
as
	select top 20 
		idAhesion,
		t_membre.nom + ' '+postnom as 'noms',
		dateAhesion,
		montantAdhesion ,
		motifAhesion,
		statutAdhesion
		
		from t_Adhesion
		inner join t_membre on t_adhesion.matriculeMembre=t_membre.matricule
		
		where matriculeMembre like '%'+@search+'%' or nom like '%'+@search+'%' or postnom like '%'+@search+'%'
		order by matriculeMembre asc

go

/* procedure supprimer adhesion*/
create procedure supprimer_adhesion
@idAhesion int as 
		delete 
			from t_Adhesion
			 where idAhesion = @idAhesion


go
/*------------------------------------------- table epargne-----------------------------------------------------*/
create table t_epargne
(
	idEpargne int identity (1,1),
	matriculeMembre nvarchar(100),
	idUser nvarchar(100),
	numeroEpargne nvarchar(100),
	designationEpargne nvarchar(100),
	libeleCompte nvarchar(100),
	montantEpargne money,
	dateVersement date
	constraint pk_idEpargne primary key(idEpargne),
	constraint fk_epargne foreign key(matriculeMembre) references t_membre(matricule),
	--constraint fk_id_user foreign key(idUser) references t_user(id_user)
)

go

/* procedure afficher epargne*/
create procedure afficher_epargne 
as		
		select top 20   
		idEpargne,
		t_membre.nom + ' '+postnom as 'membre',
		idUser,
		numeroEpargne,
		designationEpargne,
		libeleCompte,
		montantEpargne,
		dateVersement

		from t_epargne
			inner join t_membre  on t_epargne.matriculeMembre=t_membre.matricule
			--inner join t_user on t_epargne.idUser=t_user.id_user
		order by idEpargne asc

go


/*create and update epargne */
create procedure enregistrer_epargne
		
		@idEpargne int,
		@matriculeMembre nvarchar(100),
		@idUser nvarchar(100),
		@numeroEpargne nvarchar(100),
		@designationEpargne nvarchar(100),
		@libeleCompte nvarchar(100),
		@montantEpargne money,
		@dateVersement date
as
	merge into t_epargne
	using (select @idEpargne as x_id) as x_source
	on(x_source.x_id=t_epargne.idEpargne)
	when matched then
		update set
		matriculeMembre = @matriculeMembre,
		idUser = @idUser,
		numeroEpargne = @numeroEpargne,
		designationEpargne = @designationEpargne,
		libeleCompte = @libeleCompte,
		montantEpargne = @montantEpargne,
		dateVersement = @dateVersement
	when not matched then
		insert
			(matriculeMembre, idUser,numeroEpargne,designationEpargne, libeleCompte, montantEpargne, dateVersement )
		values
			(@matriculeMembre, @idUser, @numeroEpargne, @designationEpargne, @libeleCompte, @montantEpargne, @dateVersement );

go

/* procedure rechercher epargne par matricule du membre */
create procedure recherche_epargne
@search nvarchar(50)

as
	select top 20   
		idEpargne,
		t_membre.nom + ' '+postnom as 'membre',
		idUser,
		numeroEpargne,
		designationEpargne,
		libeleCompte,
		montantEpargne,
		dateVersement

		from t_epargne
			inner join t_membre  on t_epargne.matriculeMembre=t_membre.matricule
			--inner join t_user on t_epargne.idUser=t_user.id_user
		where matriculeMembre like '%'+ @search+'%'or numeroEpargne like '%'+@search+'%' or t_membre.nom like '%'+@search+'%'
		 or t_membre.postnom like '%'+@search+'%'
		order by idEpargne asc

go




/* procedure supprimer epargne*/
create procedure supprimer_epargne 
@idEpargne int
 as 
		delete
		 from t_epargne 
		 where idEpargne = @idEpargne
go
----------------------------------------Fin epargne--------

	
----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------
------------------------------------------CREATION DES ETATS DE SORTIE-------------------------------
ALTER proc Afficher_restitutin as
select 
 t_membre.nom+' '+postnom as Noms,versement, sum(montantRemb) as Montant_rembourser,
 count(*)  as trimestre ,(versement-(sum(montantRemb))) as reste
  

from t_remboursement r --group by montantRemb, --having COUNT(*)>1
inner join t_Pret on r.id_pret=t_Pret.id_pret
inner join t_membre on t_Pret.membre=t_membre.matricule
 group by t_membre.nom,postnom, t_Pret.id_pret,versement


--------------------------Plan de remboursement--------------------
alter view Plan_remboursement
as
select  nom+' '+postnom as Noms, montantRemb, dateRemb as dateRemb,
(versement*1.35) as Montant_à_Rambourser

from t_remboursement
inner join t_Pret on t_remboursement.id_pret=t_Pret.id_pret
inner join t_membre on t_Pret.membre=t_membre.matricule
---------------------RAPPORT LISTE DES MEMBRE------------------
create procedure Liste_membre as
select
 matricule,nom+' '+postnom as Noms,
  adresse,phone, sexe,lieuNaiss, 
  DATEDIFF(day,dateNaiss,getdate())/365 as Age,
   ref_type from t_membre
-------------------------------------RAPPORT FICHER DE REMBOURSEMENT-----------------
   create view fiche_remboursement_journalier as
   select dateRemb, montantRemb, nom+' '+postnom as Noms, adresse,
    t_pret.id_user, versement, date_pret,secteur
	 from t_remboursement 
   inner join t_pret on t_remboursement.id_pret=t_Pret.id_pret
   inner join t_membre on t_Pret.membre=t_membre.matricule
   ------------------------------------------------------RAPPORT BON D'ENTRER ---------
   create view Bon_entrerCaisse as
   select t_epargne.idEpargne, nom+' '+postnom as Noms , montantEpargne,designationEpargne,dateVersement, libeleCompte from t_epargne
   inner join t_membre on t_epargne.matriculeMembre=t_membre.matricule

   --------------------------------------------ETAT FICANCIER-----------------
 create procedure etat_financier as
 select 
t_membre.nom+' '+postnom as Noms,t_pret.versement,(versement*1.35)as Montant_a_rembourser,
sum(montantRemb) as MontantRembourser,
count(*)as nombre,
((versement*1.35)-sum(montantRemb))as Solde,
(0.2592*sum(montantRemb))as Interet_blob,
(0.51*(0.2592*sum(montantRemb)))as Interet,
(0.49*(0.2592*sum(montantRemb)))as Epargne,
(versement*1.35)/(sum(montantRemb))as Pourcentage
from t_remboursement r 
inner join t_Pret on r.id_pret=t_Pret.id_pret
inner join t_membre on t_Pret.membre=t_membre.matricule
--inner join t_epargne on t_membre.matricule=t_epargne.matriculeMembre
group by t_Pret.versement,t_membre.nom,postnom