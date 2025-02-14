# Sự khác nhau giữa private Calculator _cal = null!; và private Calculator? _cal = null; là gì ?

## Giải thích chi tiết

### private Calculator _cal = null!;
- **Giải thích**: Sử dụng `null!` để chỉ định rằng `_cal` sẽ không bao giờ là null sau khi khởi tạo, mặc dù nó được khởi tạo với giá trị null. Điều này giúp tránh cảnh báo của trình biên dịch về việc gán giá trị null cho một biến không cho phép null.
- **Ví dụ**:
```csharp
private Calculator _cal = null!;
```

### private Calculator? _cal = null;
- **Giải thích**: Sử dụng `null` để chỉ định rằng `_cal` có thể là null hoặc một đối tượng Calculator.
- **Ví dụ**:
```csharp
private Calculator? _cal = null;
```





