BEGIN TRANSACTION;

ALTER TABLE "Users" ADD "IsMarried" INTEGER NOT NULL DEFAULT 0;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20220921060134_IsMarriedToUserAdded', '6.0.9');

COMMIT;

