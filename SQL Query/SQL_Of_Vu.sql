--- Lấy tất cả nhà cung cấp ra.
CREATE PROC NhaCungCap_SelectAll
AS
BEGIN
	SELECT * FROM NHACUNGCAP 
END

--- Lấy tất cả hóa đươn nhập hàng ra
GO
CREATE PROC HoaDonNhap_SelectAll
AS
BEGIN 
	SELECT * FROM HDNHAPHANG
END

--- Load MAHDNH, TENNV, TENNCC, NGAYNH, TONGTIEN
GO
CREATE PROC HoaDonNhap_Load
AS
BEGIN 
	SELECT HDNH.MAHDNH, NV.TENNV, NCC.TENNCC, HDNH.NGAYNH, HDNH.TONGTIEN
	FROM HDNHAPHANG AS HDNH, NHANVIEN AS NV, NHACUNGCAP AS NCC
	WHERE HDNH.MANV = NV.MANV AND HDNH.MANCC = NCC.MANCC
END

--- Insert hóa đơn nhập
GO
CREATE PROC HoaDonNhap_Insert(
	@MAHDNH CHAR(5),
	@MANV CHAR(5),
	@MANCC CHAR(5),
	@NGAYNH SMALLDATETIME,
	@TONGTIEN MONEY
)
AS
BEGIN
	INSERT INTO HDNHAPHANG(MAHDNH, MANV, MANCC, NGAYNH, TONGTIEN) 
	VALUES (@MAHDNH, @MANV, @MANCC, @NGAYNH, @TONGTIEN)
END

--- Delete hóa đơn nhập
GO
CREATE PROC HoaDonNhap_Delete(
	@MAHDNH CHAR(5)
)
AS
BEGIN
	DELETE FROM CTHDNHAPHANG WHERE MAHDNH = @MAHDNH
	DELETE FROM HDNHAPHANG WHERE MAHDNH = @MAHDNH
END


--- Load chi tiết hóa đơn nhập
GO
CREATE PROC CTHDNhap_Load(
	@MAHDNH CHAR(5)
)
AS
BEGIN
	SELECT SP.TENSP, CTHDNH.SOLUONG, CTHDNH.GIANHAP 
	FROM SANPHAM AS SP, CTHDNHAPHANG AS CTHDNH
	WHERE CTHDNH.MASP = SP.MASP AND CTHDNH.MAHDNH = @MAHDNH
END

--- Thêm chi tiết hóa đơn nhập
GO
CREATE PROC CTHDNhap_Insert(
	@MACTHDNH CHAR(5),
	@MAHDNH CHAR(5),
	@MASP CHAR(5),
	@SOLUONG INT,
	@GIANHAP MONEY
)
AS
BEGIN
	INSERT INTO CTHDNHAPHANG(MAHDNH, MAHDNH, MASP, SOLUONG, GIANHAP) 
	VALUES (@MACTHDNH, @MAHDNH, @MASP, @SOLUONG, @GIANHAP)
END

--- Delete chi tiết hóa đơn nhập
GO
CREATE PROC CTHDNhap_Delete(
	@MACTHDNH CHAR(5)
)
AS
BEGIN
	DELETE FROM CTHDNHAPHANG WHERE MACTHDNH = @MACTHDNH
END