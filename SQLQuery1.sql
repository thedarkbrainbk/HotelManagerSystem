﻿ALTER TABLE DatPhong
ADD CONSTRAINT FK_DatPhong_Phong
FOREIGN KEY (IdPhong)
REFERENCES Phong(IdPhong);
