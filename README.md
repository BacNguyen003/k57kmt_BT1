# Bài tập 1 

## Đề tài
Xây dựng một thư viện DLL bằng C# (.NET Framework 2.0).  
DLL này có nhiệm vụ nhận **họ tên + ngày sinh** và sinh ra các thông tin 
- Slug 
- Numeric ID
- Pattern 3x3 ngẫu nhiên
- Màu sắc may mắn (mã HEX)

Yêu cầu là thư viện phải chạy được trên nhiều ứng dụng:
1. Console App  
2. WinForm App  
3. Web App ASP.NET (chạy qua IIS)

---

## Giải pháp em làm
Em tạo solution gồm 4 project:
- **SignatureLib**: DLL chính, toàn bộ xử lý logic
- **SignatureConsole**: ứng dụng console
- **SignatureWinForm**: ứng dụng desktop giao diện
- **SignatureWeb**: web app ASP.NET, gọi API `.aspx` trả JSON

Các ứng dụng này đều dùng chung DLL `SignatureLib`.

---

## Kết quả chạy thử
### Console
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/179bd7bf-6167-40ee-935f-449f133416b5" />


### WinForm
<img width="1919" height="1078" alt="image" src="https://github.com/user-attachments/assets/9447fdb8-5e24-457e-bafc-6f62ec116243" />

### Web (IIS)
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/2190f127-bb90-44ab-b490-81c8b6873da1" />
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/f687eefd-8e9c-43c1-ba83-5454b0c346d8" />
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/6d18d499-3f7f-4567-91e9-6dc134189657" />
<img width="1911" height="1079" alt="image" src="https://github.com/user-attachments/assets/6b460aec-2af8-462c-b70e-a2dff4dac823" />

---

## Nhận xét
- Đáp ứng đủ yêu cầu: DLL độc lập, có thể dùng lại trên Console, WinForm, Web.  
- Dấu ấn cá nhân: sinh **pattern 3x3** và **màu may mắn** dựa trên tên + ngày sinh.  
- IIS đã được cấu hình và chạy được web app.
