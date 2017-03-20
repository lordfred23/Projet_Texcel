USE bdTexelFredAlex
-- -- tblPlatform
alter table tblPlatform add foreign key(idSysExp) references tblSystemExploitation(idSysExp);

-- --tblPlatformJeu


-- --tblJeu
alter table tblJeu add foreign key(idClassification)references tblClassification(idClassification);

alter table tblJeu add foreign key(idTheme)references tblTheme(idTheme);
alter table tblJeu add foreign key(idGenre)references tblGenre(idGenre);
alter table tblJeu add foreign key(idPlatform)references tblPlatform(idPlatform);

-- --tblProjet
alter table tblProjet add foreign key(idJeu)references tblJeu(idJeu);


-- --tblEmploye
alter table tblEmploye add foreign key(idRole)references tblRole(idRole);

-- --tblEmployeEquipe
alter table tblEmployeEquipe add foreign key(matricule)references tblEmploye(matricule);
alter table tblEmployeEquipe add foreign key(idEquipe)references tblEquipe(idEquipe);

-- --tblTest
alter table tblTest add foreign key(idCategorieTest)references tblCategorieTest(idCategorieTest);

-- --tblTravail
alter table tblTravail add foreign key(idTest)references tblTest(idTest);
alter table tblTravail add foreign key(idEquipe)references tblEquipe(idEquipe);
alter table tblTravail add foreign key(idProjet)references tblProjet(idProjet);