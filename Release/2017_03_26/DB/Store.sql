/****** Object:  StoredProcedure [dbo].[UpdateTotalAmount]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[UpdateTotalAmount]
GO
/****** Object:  StoredProcedure [dbo].[UpdateProduct]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[UpdateProduct]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[UpdateCustomer]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetDataForAnalystGraph]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[sp_GetDataForAnalystGraph]
GO
/****** Object:  StoredProcedure [dbo].[sp_AnalystByTimeAndCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[sp_AnalystByTimeAndCustomer]
GO
/****** Object:  StoredProcedure [dbo].[SelectOrderIDByCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[SelectOrderIDByCustomer]
GO
/****** Object:  StoredProcedure [dbo].[SelectListOrderWithCustomerInfo]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[SelectListOrderWithCustomerInfo]
GO
/****** Object:  StoredProcedure [dbo].[SELECTDETAILORDER]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[SELECTDETAILORDER]
GO
/****** Object:  StoredProcedure [dbo].[InsertT_GIASANPHAM]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[InsertT_GIASANPHAM]
GO
/****** Object:  StoredProcedure [dbo].[InsertQuery]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[InsertQuery]
GO
/****** Object:  StoredProcedure [dbo].[InsertProduct]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[InsertProduct]
GO
/****** Object:  StoredProcedure [dbo].[InsertCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[InsertCustomer]
GO
/****** Object:  StoredProcedure [dbo].[GetTotalDebitByCustomerID]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[GetTotalDebitByCustomerID]
GO
/****** Object:  StoredProcedure [dbo].[GetProductPriceListByCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[GetProductPriceListByCustomer]
GO
/****** Object:  StoredProcedure [dbo].[GetProductInfoForPrinting]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[GetProductInfoForPrinting]
GO
/****** Object:  StoredProcedure [dbo].[GetOrderDetailByOrderID]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[GetOrderDetailByOrderID]
GO
/****** Object:  StoredProcedure [dbo].[GetLastOrderByCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[GetLastOrderByCustomer]
GO
/****** Object:  StoredProcedure [dbo].[DoPaymentWithAmountByCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[DoPaymentWithAmountByCustomer]
GO
/****** Object:  StoredProcedure [dbo].[DoPaymentWithAmount]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[DoPaymentWithAmount]
GO
/****** Object:  StoredProcedure [dbo].[DoPaymentQuery]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[DoPaymentQuery]
GO
/****** Object:  StoredProcedure [dbo].[DeleteProduct]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[DeleteProduct]
GO
/****** Object:  StoredProcedure [dbo].[DeleteOrderDetail]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[DeleteOrderDetail]
GO
/****** Object:  StoredProcedure [dbo].[DeleteOrderByID]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[DeleteOrderByID]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
DROP PROCEDURE [dbo].[DeleteCustomer]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCustomer]
(
	@MA_KH int
)
AS
	SET NOCOUNT OFF;
UPDATE       M_KHACHHANG
SET                TRANG_THAI = - 1
WHERE        (MA_KH = @MA_KH)

GO
/****** Object:  StoredProcedure [dbo].[DeleteOrderByID]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteOrderByID]
(
	@MA_HD varchar(50)
)
AS
	SET NOCOUNT OFF;
UPDATE [T_HOADON]
SET TRANG_THAI = -1
WHERE (MA_HD = @MA_HD)

GO
/****** Object:  StoredProcedure [dbo].[DeleteOrderDetail]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteOrderDetail]
(
	@MA_HD varchar(50),
	@ID int
)
AS
	SET NOCOUNT OFF;
UPDATE       T_CHITIETHOADON
SET                TRANG_THAI = - 1
WHERE       ID = @ID

update T_HOADON
set TONG_TIEN = ISNULL((select sum(T_CHITIETHOADON.SO_LUONG* T_CHITIETHOADON.GIA) from T_CHITIETHOADON where T_CHITIETHOADON.HOA_DON = @MA_HD and T_CHITIETHOADON.TRANG_THAI<>-1),0)
where T_HOADON.MA_HD = @MA_HD


GO
/****** Object:  StoredProcedure [dbo].[DeleteProduct]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteProduct]
(
	@MA_SP int
)
AS
	SET NOCOUNT OFF;
UPDATE       M_SANPHAM
SET                TRANG_THAI = - 1
WHERE        (MA_SP = @MA_SP)

GO
/****** Object:  StoredProcedure [dbo].[DoPaymentQuery]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DoPaymentQuery]
(
	@MA_HD varchar(50)
)
AS
	SET NOCOUNT OFF;
UPDATE       T_HOADON
SET                TRANG_THAI = 1
WHERE        (MA_HD = @MA_HD)

GO
/****** Object:  StoredProcedure [dbo].[DoPaymentWithAmount]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DoPaymentWithAmount]
(
	@PAY_AMOUNT float,
	@MA_HD varchar(50)
)
AS
	SET NOCOUNT OFF;
UPDATE       T_HOADON
SET                TIEN_TRA = TIEN_TRA + @PAY_AMOUNT
WHERE        (MA_HD = @MA_HD) AND (TRANG_THAI <> - 1)

GO
/****** Object:  StoredProcedure [dbo].[DoPaymentWithAmountByCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DoPaymentWithAmountByCustomer]
(
	@PAY_AMOUNT float,
	@CustomerID int
)
AS
	SET NOCOUNT OFF;

	declare @selectMa_HD varchar(50)
	declare @selectDebit float

WHILE @PAY_AMOUNT >0
BEGIN
	set @selectMa_HD =  (select top 1  MA_HD
								from T_HOADON
								where TRANG_THAI <>-1 and TONG_TIEN >TIEN_TRA  and KHACH_HANG = @CustomerID
								order by NGAY_LAP asc);
	set @selectDebit =  (select  TONG_TIEN - TIEN_TRA
								from T_HOADON
								where MA_HD = @selectMa_HD);

		if @selectDebit >= @PAY_AMOUNT
		begin
			update T_HOADON 
			set TIEN_TRA = TIEN_TRA + @PAY_AMOUNT
			where MA_HD = @selectMa_HD
			set @PAY_AMOUNT = 0
		end
		if @selectDebit < @PAY_AMOUNT
		begin
			set	@PAY_AMOUNT = @PAY_AMOUNT -@selectDebit
			update T_HOADON 
			set TIEN_TRA = TIEN_TRA + @selectDebit
			where MA_HD = @selectMa_HD
		end
	 
END


GO
/****** Object:  StoredProcedure [dbo].[GetLastOrderByCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetLastOrderByCustomer]
(
	@KHACH_HANG int
)
AS
	SET NOCOUNT ON;
SELECT       top 1 MA_HD
FROM            T_HOADON
WHERE        (KHACH_HANG = @KHACH_HANG) and TRANG_THAI<>-1 and TONG_TIEN<>TIEN_TRA
order by NGAY_LAP desc

GO
/****** Object:  StoredProcedure [dbo].[GetOrderDetailByOrderID]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetOrderDetailByOrderID]
(
	@HOA_DON VARCHAR(50)
)
AS
	SET NOCOUNT ON;
SELECT        M_SANPHAM.MA_SP,M_SANPHAM.TEN_SP, T_CHITIETHOADON.SO_LUONG, T_CHITIETHOADON.GIA, T_CHITIETHOADON.TRANG_THAI,T_CHITIETHOADON.THOI_GIAN_TAO,T_CHITIETHOADON.GHI_CHU,T_CHITIETHOADON.ID
FROM            T_CHITIETHOADON INNER JOIN
                         M_SANPHAM ON T_CHITIETHOADON.SAN_PHAM = M_SANPHAM.MA_SP
WHERE        (T_CHITIETHOADON.HOA_DON = @HOA_DON) and T_CHITIETHOADON.TRANG_THAI <>-1
order by T_CHITIETHOADON.THOI_GIAN_TAO desc

GO
/****** Object:  StoredProcedure [dbo].[GetProductInfoForPrinting]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProductInfoForPrinting]
(
	@MA_KH int
)
AS
	SET NOCOUNT ON;
SELECT        M_SANPHAM.TEN_SP, M_SANPHAM.DON_VI_TINH, M_SANPHAM.TRANG_THAI, T_GIASANPHAM.GIA_A, T_GIASANPHAM.GIA_B, T_GIASANPHAM.GIA_C, T_GIASANPHAM.TINH_TRANG
FROM            M_SANPHAM INNER JOIN
                         T_GIASANPHAM ON M_SANPHAM.MA_SP = T_GIASANPHAM.SAN_PHAM
WHERE        (T_GIASANPHAM.KHACH_HANG = @MA_KH) AND (M_SANPHAM.TRANG_THAI <> - 1)

GO
/****** Object:  StoredProcedure [dbo].[GetProductPriceListByCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProductPriceListByCustomer]
(
	@MA_KH int
)
AS
	SET NOCOUNT ON;
SELECT        M_SANPHAM.MA_SP, M_SANPHAM.TEN_SP, M_SANPHAM.DON_VI_TINH, GIASANPHAM.GIA_A, GIASANPHAM.GIA_B, GIASANPHAM.GIA_C, GIASANPHAM.TINH_TRANG, GIASANPHAM.KHACH_HANG
FROM            M_SANPHAM left JOIN (select * from T_GIASANPHAM 
						 left join M_KHACHHANG on KHACH_HANG = MA_KH
						 where KHACH_HANG = @MA_KH) as GIASANPHAM
                          ON M_SANPHAM.MA_SP = GIASANPHAM.SAN_PHAM
WHERE M_SANPHAM.TRANG_THAI<>-1

						 

GO
/****** Object:  StoredProcedure [dbo].[GetTotalDebitByCustomerID]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTotalDebitByCustomerID]
(
	@KHACH_HANG int
)
AS
	SET NOCOUNT ON;
SELECT        SUM(TONG_TIEN) - SUM(TIEN_TRA) AS OLD_DEBIT
FROM            T_HOADON
WHERE        (KHACH_HANG = @KHACH_HANG) and TRANG_THAI<>-1 and  TRANG_THAI<>0 and TONG_TIEN<>TIEN_TRA and MA_HD <> (SELECT       top 1 MA_HD
																													FROM            T_HOADON
																													WHERE        (KHACH_HANG = @KHACH_HANG) 
																													and TRANG_THAI<>-1 
																													and TONG_TIEN<>TIEN_TRA
																													order by NGAY_LAP desc)

GO
/****** Object:  StoredProcedure [dbo].[InsertCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCustomer]
(
	@TEN_KH nvarchar(50),
	@DIA_CHI nvarchar(200),
	@SO_DT nvarchar(20),
	@GHI_CHU nvarchar(500),
	@TRANG_THAI int,
	@LOAI_KHACH int
)
AS
	SET NOCOUNT OFF;
INSERT INTO M_KHACHHANG
                         (TEN_KH, DIA_CHI, SO_DT, GHI_CHU, TRANG_THAI, LOAI_KHACH)
VALUES        (@TEN_KH,@DIA_CHI,@SO_DT,@GHI_CHU,@TRANG_THAI,@LOAI_KHACH)

GO
/****** Object:  StoredProcedure [dbo].[InsertProduct]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertProduct]
(
	@TEN_SP nvarchar(100),
	@DON_VI_TINH nvarchar(20),
	@GHI_CHU nvarchar(200),
	@TRANG_THAI int
)
AS
	SET NOCOUNT OFF;
INSERT INTO M_SANPHAM
                         (TEN_SP, DON_VI_TINH, GHI_CHU, TRANG_THAI)
VALUES        (@TEN_SP,@DON_VI_TINH,@GHI_CHU,@TRANG_THAI)

GO
/****** Object:  StoredProcedure [dbo].[InsertQuery]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertQuery]
(
	@NGAY_LAP datetime,
	@GHI_CHU nvarchar(200),
	@TONG_TIEN float,
	@TRANG_THAI int,
	@KHACH_HANG int
)
AS
	SET NOCOUNT OFF;
declare @ma_hd varchar(50);
select @ma_hd= dbo.CreateOrderIDByDateTime(@NGAY_LAP); 
INSERT INTO [dbo].[T_HOADON] ([MA_HD],[NGAY_LAP], [GHI_CHU], [TONG_TIEN], [TRANG_THAI], [KHACH_HANG],[TIEN_TRA]) VALUES (@ma_hd,@NGAY_LAP, @GHI_CHU, @TONG_TIEN, @TRANG_THAI, @KHACH_HANG,0);
	
SELECT MA_HD, NGAY_LAP, GHI_CHU, TONG_TIEN, TRANG_THAI, KHACH_HANG FROM T_HOADON WHERE (MA_HD = @ma_hd);
	Select @ma_hd


GO
/****** Object:  StoredProcedure [dbo].[InsertT_GIASANPHAM]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertT_GIASANPHAM]
(
	@MA_KH int,
	@MA_SP int,
	@GIA_A float,
	@GIA_B float,
	@GIA_C float,
	@TINH_TRANG int
)
AS
	SET NOCOUNT OFF;

	declare @hasRow int;
select @hasRow = (select count(*) from T_GIASANPHAM
where SAN_PHAM = @MA_SP and KHACH_HANG = @MA_KH)

if @hasRow > 0
begin
	update T_GIASANPHAM
	set GIA_A = @GIA_A , GIA_B = @GIA_B , GIA_C = @GIA_C
	where KHACH_HANG = @MA_KH and SAN_PHAM = @MA_SP
end
else
begin

INSERT INTO T_GIASANPHAM
                         (KHACH_HANG, SAN_PHAM, GIA_A, GIA_B, GIA_C, TINH_TRANG)
VALUES        (@MA_KH,@MA_SP,@GIA_A,@GIA_B,@GIA_C,@TINH_TRANG)

end

GO
/****** Object:  StoredProcedure [dbo].[SELECTDETAILORDER]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELECTDETAILORDER]
(
	@MA_HD varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        T_CHITIETHOADON.THOI_GIAN_TAO, M_SANPHAM.TEN_SP, M_SANPHAM.DON_VI_TINH, T_CHITIETHOADON.GIA, T_CHITIETHOADON.SO_LUONG, T_CHITIETHOADON.SO_LUONG*T_CHITIETHOADON.GIA as THANH_TIEN,T_CHITIETHOADON.GHI_CHU
FROM            M_SANPHAM INNER JOIN T_CHITIETHOADON ON MA_SP = SAN_PHAM
WHERE        (T_CHITIETHOADON.HOA_DON = @MA_HD) and T_CHITIETHOADON.TRANG_THAI <>-1
order by T_CHITIETHOADON.THOI_GIAN_TAO asc

GO
/****** Object:  StoredProcedure [dbo].[SelectListOrderWithCustomerInfo]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectListOrderWithCustomerInfo]
AS
	SET NOCOUNT ON;
SELECT        T_HOADON.MA_HD, T_HOADON.NGAY_LAP, T_HOADON.TONG_TIEN, T_HOADON.GHI_CHU, T_HOADON.TRANG_THAI, T_HOADON.TIEN_TRA, T_HOADON.KHACH_HANG, M_KHACHHANG.TEN_KH, 
                         M_KHACHHANG.SO_DT, M_KHACHHANG.GHI_CHU AS Expr1, M_KHACHHANG.TRANG_THAI AS Expr2, M_KHACHHANG.DIA_CHI, M_KHACHHANG.MA_KH
FROM            T_HOADON INNER JOIN
                         M_KHACHHANG ON T_HOADON.KHACH_HANG = M_KHACHHANG.MA_KH
WHERE T_HOADON.TRANG_THAI <>-1
order by T_HOADON.TRANG_THAI asc,T_HOADON.NGAY_LAP desc

GO
/****** Object:  StoredProcedure [dbo].[SelectOrderIDByCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectOrderIDByCustomer]
(
	@MA_KH int
)
AS
	SET NOCOUNT ON;
SELECT        MA_HD
FROM            T_HOADON
WHERE        (TRANG_THAI = 0) and KHACH_HANG = @MA_KH

GO
/****** Object:  StoredProcedure [dbo].[sp_AnalystByTimeAndCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_AnalystByTimeAndCustomer] 
	@startDate datetime,
	@endDate datetime,
	@customerID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    Select  TEN_SP,GIA, sum(SO_LUONG) as SO_LUONG,sum(GIA*SO_LUONG) as Total
	from M_SANPHAM inner join ( select NGAY_LAP,SAN_PHAM, SO_LUONG,GIA from T_HOADON 
								inner join T_CHITIETHOADON 
								on MA_HD = HOA_DON 
								where KHACH_HANG = @customerID and T_HOADON.TRANG_THAI = 1 and TONG_TIEN = TIEN_TRA and T_CHITIETHOADON.TRANG_THAI<>-1) as HOADON
	on MA_SP = SAN_PHAM
	where NGAY_LAP between @startDate and @endDate 
	group by TEN_SP,GIA
END


GO
/****** Object:  StoredProcedure [dbo].[sp_GetDataForAnalystGraph]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetDataForAnalystGraph] 
	@year int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    declare @jan float;
	declare @feb float;
	declare @mar float;
	declare @apr float;
	declare @may float;
	declare @jun float;
	declare @jul float;
	declare @aug float;
	declare @sep float;
	declare @oct float;
	declare @nov float;
	declare @dec float;

	select @jan= ISNULL( dbo.GetTotalAmountByMonth(1,@year),0);
	select @feb= ISNULL( dbo.GetTotalAmountByMonth(2,@year),0);
	select @mar= ISNULL( dbo.GetTotalAmountByMonth(3,@year),0);
	select @apr= ISNULL( dbo.GetTotalAmountByMonth(4,@year),0);
	select @may= ISNULL( dbo.GetTotalAmountByMonth(5,@year),0);
	select @jun= ISNULL( dbo.GetTotalAmountByMonth(6,@year),0);
	select @jul= ISNULL( dbo.GetTotalAmountByMonth(7,@year),0);
	select @aug= ISNULL( dbo.GetTotalAmountByMonth(8,@year),0);
	select @sep= ISNULL( dbo.GetTotalAmountByMonth(9,@year),0);
	select @oct= ISNULL( dbo.GetTotalAmountByMonth(10,@year),0);
	select @nov= ISNULL( dbo.GetTotalAmountByMonth(11,@year),0);
	select @dec= ISNULL( dbo.GetTotalAmountByMonth(12,@year),0);

	--select @jan= 100;
	--select @feb= 240;
	--select @mar= 200;
	--select @apr= 95;
	--select @may= 80;
	--select @jun= 100;
	--select @jul= 110;
	--select @aug= 180;
	--select @sep= 150;
	--select @oct= 160;
	--select @nov= 170;
	--select @dec= 210;


	select @jan,@feb,@mar,@apr,@may,@jun,@jul,@aug,@sep,@oct,@nov,@dec
END


GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomer]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCustomer]
(
	@TEN_KH nvarchar(50),
	@DIA_CHI nvarchar(200),
	@SO_DT nvarchar(20),
	@GHI_CHU nvarchar(500),
	@LOAI_KHACH int,
	@TRANG_THAI int,
	@MA_KH int
)
AS
	SET NOCOUNT OFF;
UPDATE       M_KHACHHANG
SET                TEN_KH = @TEN_KH, DIA_CHI = @DIA_CHI, SO_DT = @SO_DT, GHI_CHU = @GHI_CHU, LOAI_KHACH = @LOAI_KHACH, TRANG_THAI = @TRANG_THAI
WHERE        (MA_KH = @MA_KH)

GO
/****** Object:  StoredProcedure [dbo].[UpdateProduct]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateProduct]
(
	@TEN_SP nvarchar(100),
	@DON_VI_TINH nvarchar(20),
	@GHI_CHU nvarchar(200),
	@MA_SP int
)
AS
	SET NOCOUNT OFF;
UPDATE       M_SANPHAM
SET                TEN_SP = @TEN_SP, DON_VI_TINH = @DON_VI_TINH, GHI_CHU = @GHI_CHU
WHERE        (MA_SP = @MA_SP)

GO
/****** Object:  StoredProcedure [dbo].[UpdateTotalAmount]    Script Date: 26/3/2017 9:35:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateTotalAmount]
(
	@TONG_TIEN float,
	@MA_HD varchar(50)
)
AS
	SET NOCOUNT OFF;
UPDATE       T_HOADON
SET                TONG_TIEN += @TONG_TIEN
WHERE        (MA_HD = @MA_HD);
	 
SELECT MA_HD, NGAY_LAP, GHI_CHU, TONG_TIEN, TRANG_THAI, KHACH_HANG, TIEN_TRA FROM T_HOADON WHERE (MA_HD = @MA_HD)

GO
