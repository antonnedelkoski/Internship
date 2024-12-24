USE [C:\USERS\ANTON\SOURCE\REPOS\STORES_DB_TASK\STORES_DB_TASK\LASTTRY.MDF];
GO

SELECT ime_rabotnik,prezime_rabotnik,raboti_na_kasa,prodavnica.ime_prodavnica as vo_market,prodavnica.id_prodavnica as so_id FROM Rabotnik 
JOIN Kasa ON Rabotnik.raboti_na_kasa = Kasa.id_kasa 
JOIN Prodavnica ON Kasa.prodavnica_id = Prodavnica.id_prodavnica
