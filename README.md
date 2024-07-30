# BookStore Online

BookStore Online là một ứng dụng web bán sách trực tuyến, được xây dựng bằng C# sử dụng .NET MVC và SQL Server. Dự án này cung cấp các chức năng cơ bản cho một cửa hàng sách trực tuyến bao gồm trang chủ, giỏ hàng, tìm kiếm, chi tiết sản phẩm, đặt hàng, và chức năng đăng nhập/đăng ký. Ngoài ra, một giao diện quản lý cho admin cũng được tích hợp cho phép quản lý sản phẩm, danh mục và người dùng.

## Các Tính Năng

- **Trang chủ**: Hiển thị các sách nổi bật và mới nhất.
- **Giỏ hàng**: Người dùng có thể thêm và quản lý các sản phẩm trong giỏ hàng của họ.
- **Tìm kiếm**: Tìm kiếm sách dựa trên tên hoặc thể loại.
- **Chi tiết sản phẩm**: Hiển thị thông tin chi tiết về sản phẩm.
- **Đặt hàng**: Người dùng có thể đặt hàng và xem lịch sử đơn hàng.
- **Đăng nhập/Đăng ký**: Cho phép người dùng đăng ký tài khoản và đăng nhập.
- **Quản lý (Admin)**: Quản lý sản phẩm, danh mục sách, và người dùng.

## Công Nghệ

- **Back-end**: C# .NET MVC
- **Database**: SQL Server
- **Front-end**: HTML, CSS, JavaScript

## Cài Đặt

Để chạy được ứng dụng, bạn cần thực hiện các bước sau:

1. **Clone Repository**
git clone https://github.com/NhaDuX/BookStoreOnline_C-Sharp_.NETMVC_MSSqlServer.git

2. **Cài Đặt SQL Server và Attach Database**
- Cài đặt SQL Server nếu chưa có.
- Attach file `BookStore.mdf` vào SQL Server của bạn.

3. **Cập Nhật Connection String**
- Mở file `Web.config`.
- Tìm đến section `connectionStrings` và thay đổi giá trị `data source=YOURSERVERNAME` với tên server SQL Server của bạn.

4. **Build và Run**
- Mở solution trong Visual Studio.
- Build và chạy ứng dụng.

## Đóng Góp

Cảm ơn bạn đã quan tâm đến việc đóng góp cho dự án của chúng tôi. Mọi đóng góp ý kiến hoặc báo cáo lỗi vui lòng tạo Issue hoặc Pull Request trực tiếp trên GitHub.

