# CSV Read/Write Application

A Windows Forms application for viewing and editing CSV files with multiple encoding support.

![Application Screenshot](ss.png) 

## Features
- 📁 Open and view CSV files
- 💾 Save edited data back to CSV
- 🔤 Multiple encoding support:
  - Auto-detection
  - UTF-8
  - UTF-16
  - Shift_JIS
- 📊 Data displayed in editable DataGridView
- ✅ Basic error handling and validation

## Usage
1. Select input CSV file using "参照" button
2. Choose appropriate encoding (default: Auto)
3. Click "CSV取得" to load file
4. Edit data directly in the grid
5. Specify output file and click "CSV出力" to save

## Requirements
- .NET 8.0 Runtime
- Windows OS

## Installation
1. Clone this repository
2. Build solution in Visual Studio
3. Run the executable

## License
MIT License

## Contributing
Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change.

Please make sure to update tests as appropriate.
