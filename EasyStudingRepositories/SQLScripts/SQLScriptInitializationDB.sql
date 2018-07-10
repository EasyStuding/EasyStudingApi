create table "Users"
(
	"Id" bigserial not null primary key,

	"TelephoneNumber" text not null UNIQUE,
	"TelephoneNumberIsValidated" boolean default false not null,

	"RegistrationDate" timestamptz default now() not null,
	"Role" text default 'user' not null,

	"BanExpiresDate" timestamptz default now() not null,
	"SubscriptionExecutorExpiresDate" timestamptz default now() not null,
	"SubscriptionOpenSourceExpiresDate" timestamptz default now() not null,

	"Education" text null,
	"EducationType" text null,

	"FullName" text null,
	"Description" text null,
	"PictureLink" text null,

		"Email" text null UNIQUE,
		"EmailIsValidated" boolean default false not null,

		"Country" text null,
		"Region" text null,
		"City" text null,

	"UserIsGaranted" boolean default false not null,
	"Raiting" decimal default 0 not null
);

create table "Attachments"
(
	"Id" bigserial not null primary key,
	"ContainerId" bigint not null,
	"ContainerName" text not null,
	"Name" text not null,
	"Type" text not null,
	"Link" text not null
);

create table "Skills"
(
	"Id" bigserial not null primary key,
	"Name" text not null
);

create table "Orders"
(
	"Id" bigserial not null primary key,
	"CustomerId" bigint references "Users"("Id") not null,
	"ExecutorId" bigint references "Users"("Id") null,
	"InProgress" boolean default false not null,
	"IsClosedByCustomer" boolean default false not null,
	"IsClosedByExecutor" boolean default false not null,
	"IsCompleted" boolean default false not null,
	"Title" text not null,
	"Description" text not null
);

create table "Reviews"
(
	"Id" bigserial not null primary key,
	"ReviewOwnerId" bigint references "Users"("Id") not null,
	"ReviewRecipientId" bigint references "Users"("Id") not null,
	"OrderId" bigint references "Orders"("Id") not null,
	"Title" text not null,
	"Description" text not null,
	"Raiting" decimal default 5 not null
);

create table "UserSkills"
(
	"Id" bigserial not null primary key,
	"UserId" bigint references "Users"("Id") not null,
	"SkillId" bigint references "Skills"("Id") not null
);

create table "OrderSkills"
(
	"Id" bigserial not null primary key,
	"OrderId" bigint references "Orders"("Id") not null,
	"SkillId" bigint references "Skills"("Id") not null
);

create table "UserPasswords"
(
	"Id" bigserial not null primary key,
	"UserId"  bigint references "Users"("Id") not null,
	"Password" text not null
);

CREATE OR REPLACE FUNCTION procedure_update_user_rating() RETURNS TRIGGER AS $$
BEGIN
    IF TG_OP = 'INSERT' THEN
        UPDATE "Users" SET "Raiting" = (select AVG("Raiting") from "Reviews"
	WHERE "ReviewRecipientId" = NEW."ReviewRecipientId")
  	WHERE "Id" = NEW."ReviewRecipientId";
        RETURN NEW;
    ELSIF TG_OP = 'UPDATE' THEN
        UPDATE "Users" SET "Raiting" = (select AVG("Raiting") from "Reviews"
	WHERE "ReviewRecipientId" = NEW."ReviewRecipientId")
  	WHERE "Id" = NEW."ReviewRecipientId";
        RETURN NEW;
    ELSIF TG_OP = 'DELETE' THEN
        UPDATE "Users" SET "Raiting" = (select AVG("Raiting") from "Reviews"
	WHERE "ReviewRecipientId" = OLD."ReviewRecipientId")
  	WHERE "Id" = OLD."ReviewRecipientId";
        RETURN OLD;
    END IF;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trigger_update_review
AFTER INSERT OR UPDATE OR DELETE ON "Reviews" FOR EACH ROW EXECUTE PROCEDURE procedure_update_user_rating();

INSERT INTO "Users"("TelephoneNumber", 
					"TelephoneNumberIsValidated", 
					"RegistrationDate", 
					"Role", 
					"BanExpiresDate", 
					"SubscriptionExecutorExpiresDate",
				    "SubscriptionOpenSourceExpiresDate",
				    "FullName",
				    "PictureLink",
				    "Email",
				    "EmailIsValidated",
				    "UserIsGaranted",
				    "Raiting") VALUES
    ('+375295292803'
	 , true
	 , '2018-06-26 00:00:00+03'
	 , 'admin'
	 , '2018-06-26 00:00:00+03'
	 , '2118-06-26 00:00:00+03'
	 , '2118-06-26 00:00:00+03'
	 , 'Admin'
	 , 'https://sites.google.com/site/conosceretelegram/_/rsrc/1461101123056/utenti-gruppi-supergruppi-canali-e-bot/supergruppi-disegno.jpg'
	 , 'easy_studing_api_support@gmail.com'
	 , true
	 , true
	 , 5);

INSERT INTO "UserPasswords"("UserId",
				    "Password") VALUES
    (1, 'ABZdDHl9EXtrdNeD0+M0yQwhfwMWKCGgKsouM9K300u6RaNW2wCeReAJt01sg6vQZw==');