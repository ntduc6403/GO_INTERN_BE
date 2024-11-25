# GOLDEN OWL SOLUTIONS

## Mô tả
GOLDEN OWL SOLUTIONS là một ứng dụng API để quản lý điểm số của học sinh. Ứng dụng cho phép bạn truy cập và quản lý dữ liệu điểm số thông qua các endpoint RESTful.

## Hướng dẫn chạy dự án

### Bước 1: Cài đặt môi trường

1. **Cài đặt .NET SDK**: Đảm bảo rằng bạn đã cài đặt .NET SDK phiên bản 8.0 hoặc cao hơn. Bạn có thể tải xuống từ [trang chính thức của .NET](https://dotnet.microsoft.com/download).

2. **Cài đặt SQL Server**: Đảm bảo rằng bạn đã cài đặt SQL Server và có quyền truy cập vào nó. Bạn có thể sử dụng SQL Server Express nếu cần.

### Bước 2: Tạo cơ sở dữ liệu và cập nhật dữ liệu

1. **Mở SQL Server Management Studio (SSMS)**: Kết nối đến máy chủ SQL Server của bạn.

2. **Chạy file SQL**:
   - Mở file `SQLQueryGOData.sql` trong SSMS.
   - Chạy toàn bộ nội dung của file để tạo cơ sở dữ liệu `GO_TEST` và bảng `Scores`, cũng như chèn dữ liệu mẫu vào bảng.

### Bước 3: Cấu hình kết nối

1. **Mở file `appsettings.json`**: Trong thư mục dự án, mở file `appsettings.json`.

2. **Kiểm tra chuỗi kết nối**: Đảm bảo rằng chuỗi kết nối trong phần `ConnectionStrings` trỏ đến máy chủ SQL Server của bạn. Ví dụ:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=TIENDUC\\SQLEXPRESS;Database=GO_TEST;User Id=sa;Password=123;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true"
   }
   ```

### Bước 4: Chạy ứng dụng

1. **Mở terminal**: Điều hướng đến thư mục dự án.

2. **Chạy lệnh**:
   ```bash
   dotnet run
   ```

3. **Truy cập API**: Mở trình duyệt và truy cập vào địa chỉ `http://localhost:7040/swagger` để xem tài liệu API và thử nghiệm các endpoint.

### Bước 5: Kiểm tra dữ liệu

- Bạn có thể sử dụng các endpoint trong API để kiểm tra dữ liệu đã được chèn vào bảng `Scores`. Ví dụ, bạn có thể gọi endpoint `GET /api/scores` để lấy danh sách tất cả các điểm số.
"# GO_INTERN_BE" 
