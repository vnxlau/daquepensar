CREATE TYPE "role_enum" AS ENUM (
  'student',
  'teacher',
  'manager'
);

CREATE TABLE "student" (
  "id" SERIAL PRIMARY KEY,
  "name" varchar,
  "user_id" int,
  "active" boolean DEFAULT true,
  "created_at" timestamp,
  "created_by" int,
  "modified_at" timestamp,
  "modified_by" int
);

CREATE TABLE "teacher" (
  "id" SERIAL PRIMARY KEY,
  "name" varchar,
  "user_id" int,
  "active" boolean DEFAULT true,
  "created_at" timestamp,
  "created_by" int,
  "modified_at" timestamp,
  "modified_by" int
);

CREATE TABLE "class" (
  "id" SERIAL PRIMARY KEY,
  "active" boolean DEFAULT true,
  "created_at" timestamp,
  "created_by" int,
  "modified_at" timestamp,
  "modified_by" int
);

CREATE TABLE "individualClass" (
  "id" SERIAL PRIMARY KEY,
  "teacher_id" int,
  "student_id" int,
  "active" boolean DEFAULT true,
  "created_at" timestamp,
  "created_by" int,
  "modified_at" timestamp,
  "modified_by" int
);

CREATE TABLE "classTeacher" (
  "id" SERIAL PRIMARY KEY,
  "teacher_id" int,
  "class_id" int,
  "active" boolean DEFAULT true,
  "created_at" timestamp,
  "created_by" int,
  "modified_at" timestamp,
  "modified_by" int
);

CREATE TABLE "classStudent" (
  "id" SERIAL PRIMARY KEY,
  "class_id" int,
  "student_id" int,
  "active" boolean DEFAULT true,
  "created_at" timestamp,
  "created_by" int,
  "modified_at" timestamp,
  "modified_by" int
);

CREATE TABLE "user" (
  "id" SERIAL PRIMARY KEY,
  "email" varchar,
  "password" varchar,
  "active" boolean DEFAULT true,
  "created_at" timestamp,
  "created_by" varchar,
  "modified_at" timestamp,
  "modified_by" varchar
);

CREATE TABLE "userRole" (
  "id" SERIAL PRIMARY KEY,
  "user_id" int,
  "role_id" role_enum,
  "active" boolean DEFAULT true,
  "created_at" timestamp,
  "created_by" varchar,
  "modified_at" timestamp,
  "modified_by" varchar
);

ALTER TABLE "student" ADD FOREIGN KEY ("user_id") REFERENCES "user" ("id");

ALTER TABLE "student" ADD FOREIGN KEY ("created_by") REFERENCES "user" ("id");

ALTER TABLE "student" ADD FOREIGN KEY ("modified_by") REFERENCES "user" ("id");

ALTER TABLE "teacher" ADD FOREIGN KEY ("user_id") REFERENCES "user" ("id");

ALTER TABLE "teacher" ADD FOREIGN KEY ("created_by") REFERENCES "user" ("id");

ALTER TABLE "teacher" ADD FOREIGN KEY ("modified_by") REFERENCES "user" ("id");

ALTER TABLE "class" ADD FOREIGN KEY ("created_by") REFERENCES "user" ("id");

ALTER TABLE "class" ADD FOREIGN KEY ("modified_by") REFERENCES "user" ("id");

ALTER TABLE "individualClass" ADD FOREIGN KEY ("teacher_id") REFERENCES "teacher" ("id");

ALTER TABLE "individualClass" ADD FOREIGN KEY ("student_id") REFERENCES "student" ("id");

ALTER TABLE "individualClass" ADD FOREIGN KEY ("created_by") REFERENCES "user" ("id");

ALTER TABLE "individualClass" ADD FOREIGN KEY ("modified_by") REFERENCES "user" ("id");

ALTER TABLE "classTeacher" ADD FOREIGN KEY ("teacher_id") REFERENCES "teacher" ("id");

ALTER TABLE "classTeacher" ADD FOREIGN KEY ("class_id") REFERENCES "class" ("id");

ALTER TABLE "classTeacher" ADD FOREIGN KEY ("created_by") REFERENCES "user" ("id");

ALTER TABLE "classTeacher" ADD FOREIGN KEY ("modified_by") REFERENCES "user" ("id");

ALTER TABLE "classStudent" ADD FOREIGN KEY ("class_id") REFERENCES "class" ("id");

ALTER TABLE "classStudent" ADD FOREIGN KEY ("student_id") REFERENCES "student" ("id");

ALTER TABLE "classStudent" ADD FOREIGN KEY ("created_by") REFERENCES "user" ("id");

ALTER TABLE "classStudent" ADD FOREIGN KEY ("modified_by") REFERENCES "user" ("id");

ALTER TABLE "userRole" ADD FOREIGN KEY ("user_id") REFERENCES "user" ("id");
