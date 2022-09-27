--Demo Data
if not exists (select 1 from dbo.[User])
begin
	 insert into dbo.[User] (FirstName, LastName)
	 values ('Dima','Korets'),
	 ('Sasha','Bogomazova'),
	 ('Vladimir','Bobkov');
end