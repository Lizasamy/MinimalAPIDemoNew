if not exists (select 1 from dbo.[User])
begin
insert into dbo.[User] (FirstName,LastName)
Values ('Liza','Samy'),
('Sara','Neamatallah'),
('Reem','Tarek'),
('Ashraf','Labib');
end