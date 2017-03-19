USE bdTexelFredAlex
insert into tblSystemExploitation(idSysExp,nom,version,edition)
Values
(1,'Windows','XP','famillial'),
(2,'Windows','XP','pro'),
(3,'Windows','XP','Ultimate'),
(4,'Linux','ubuntu','12.04'),
(5,'Linux','ubuntu','16.04'),
(6,'Mac OS','Sierra','10.12.3'),
(7,'Mac OS','El Capitain','10.11.6');

insert into tblPlatform(idPlatform,nom,config,typePlatform,idSysExp)
values
(1,'HomiesPC','Intel core 2 duo gtx 450 4 gb ram ','PC',1),
(2,'pc à fred','i7 6700k 16gb ram gtx 1070','PC',2);

insert into tblTheme(idTheme,nom,description)
values
(1,'Espionnage','Jeu d''espionnage de toute forme'),
(2,'Horreur','Jeu qui fait peur'),
(3,'fantasy','Jeu dans un univers fantastique');

insert into tblGenre(idGenre,nom,description)
values
(1,'Action','Tout jeu faisant appel de la part du joueur à une mise à l''épreuve de ses réflexes et de son habileté à diriger l''avancement de la partie'),
(2,'Jeux de Rôle','La majorité d''entre eux invite le joueur à incarner un ou plusieurs « aventuriers » qui se spécialisent dans un domaine spécifique (combat, magie, etc.) et à les faire progresser à l''intérieur d''une intrigue linéaire'),
(3,'Aventure','Le jeu d''aventure est un type de jeu vidéo caractérisant les jeux vidéo dont l''intérêt prédominant se focalise sur la narration plutôt que sur les réflexes et l''action');

insert into tblClassification(idClassification,nom,descrption)
values
(1,'E','Tout publics'),
(2,'EC','Jeune enfants'),
(3,'T','Adolescents'),
(4,'E10','Enfant 10ans +'),
(5,'M','Adolescents 17+'),
(6,'A','Adultes Seulement');

insert into tblJeuTheme(idJeu,idTheme)
values
(1,1),
(2,3);

insert into tblGenreJeu(idJeu,idGenre)
values
(1,1)
(2,2);

insert into tblJeu(idJeu,developpeur,description,minimalConfig,idClassification,nom)
value
(1,'Ubisoft','Jeu d''assassin historique','4gb de ram,gtx 960+',3,'Assassin''s Creed'),
(2,'CD Projekt RED','Jeu de role médiéval','8GB de ram gtx 980+',5,'The Witcher 3');

insert into tblPlatformJeu(idJeu,idPlatform)
values
(1,2),
(2,2);

insert into tblRole(idRole,nom,description)
values
(1,'Administrateur','Administre le system'),
(2,'Utilisateur','simple utilisateur avec droit limité');

insert into tblEmploye(matricule,nom,prenom,dateNaissance,adresse,noTelephone,posteTelephone,noTelephoneMaison,idRole)
values
('A153857','Côté','Frédéric',' 12 octobre 1991','3826 st-germaine jonquière','4185478589','456','4189994584',1),
('A153578','Tremblay','Alexandre',' 29 octobre 1992','3826 st-stanisla jonquière','4185474189','430','4189894574',1);

insert into tblEquipe(idEquipe,nom,description)
values
(1,'les pro du test',,'la meilleur equipe du monde');

insert into tblEmployeEquipe(matricule,idEquipe)
values
('A153857',1),
('A153578',1);

insert into tblCategorieTest(idCategorieTest,nom,description)
values
(1,'Basique','test basique de mechanique de jeux');

insert into tblTest(idTest,description,resultat,idCategorieTest)
values
(1,'test de mechanique de jeux du personnage principal','18',1);

insert into tblProjet(idProjet,idJeu,nom,description)
values
(1,1,'Projet Assassin''s','Tester le jeux dans sont intégralité');

insert into tblTravail(idTest,idEquipe,idProjet)
values
values(1,1,1);





