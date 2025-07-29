
CREATE TABLE mcquestion (
  id INT IDENTITY PRIMARY KEY,
  question_text NVARCHAR(255)
);

CREATE TABLE mcanswer (
  id INT IDENTITY PRIMARY KEY,
  question_id INT,
  option_label CHAR(1), -- 'A', 'B', 'C', 'D'
  option_text NVARCHAR(100),
  is_correct BIT,
  FOREIGN KEY (question_id) REFERENCES mcquestion(id) ON DELETE CASCADE
);

CREATE TABLE tfquestion (
  id INT IDENTITY PRIMARY KEY,
  question_text NVARCHAR(255)
);

CREATE TABLE tfanswer (
  id INT IDENTITY PRIMARY KEY,
  question_id INT,
  is_true BIT, -- 1 = True, 0 = False
  FOREIGN KEY (question_id) REFERENCES tfquestion(id) ON DELETE CASCADE
);

CREATE TABLE openquestion (
  id INT IDENTITY PRIMARY KEY,
  question_text NVARCHAR(255)
);

CREATE TABLE openanswer (
  id INT IDENTITY PRIMARY KEY,
  question_id INT,
  answer_text NVARCHAR(255),
  is_main_answer BIT DEFAULT 0, -- 1 = câu trả lời chính thức, 0 = câu trả lời thay thế
  FOREIGN KEY (question_id) REFERENCES openquestion(id) ON DELETE CASCADE
);
