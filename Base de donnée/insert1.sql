USE bdTexelFredAlex
insert into tblSystemExploitation(idSysExp,nom,version,edition)
Values
(1,'Windows','XP','famillial'),
(2,'Windows','XP','pro'),
(3,'Windows','XP','Ultimate'),
(4,'Linux','ubuntu','12.04'),
(5,'Linux','ubuntu','16.04'),
(6,'Mac OS','Sierra','10.12.3'),
(7,'Mac OS','El Capitain','10.11.6'),

insert into tblPlatform(idPlatform,nom,config,typePlatform,idSysExp)
values
(1,'HomiesPC','Intel core 2 duo gtx 450 4 gb ram ','PC',1),
(1,'pc à fred','i7 6700k 16gb ram gtx 1070','PC',2),

insert into tblJeu


