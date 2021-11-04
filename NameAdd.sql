drop TRIGGER if exists `nameadd`;
delimiter //
create TRIGGER NameAdd
before insert on ticketinfo for EACH row
begin
if NEW.TicketBuyer not in (select username from userinfo)
then 
insert into userinfo(username,userisvip) 
values(NEW.TicketBuyer,b'0');
end if;
end;//
delimiter ;