SELECT P.IdPhong, P.TenPhong, LP.TenLoaiPhong, P.TinhTrangPhong, P.IsVip
            FROM Phong P
            JOIN LoaiPhong LP ON P.IdLoaiPhong = LP.IdLoaiPhong