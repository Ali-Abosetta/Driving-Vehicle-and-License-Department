# Windows Forms Delegation Guide (The DataBack Pattern)

This is the 4-step pattern used to pass data between any two forms in C# without reloading the database.

## Step 1: Create the Event (Inside the Child Form)
Go to the very top of your child form class (e.g., `frmEditApplication.cs`), and declare the delegate and event. This creates the "megaphone" that will shout back to the main form:

```csharp
// 1. Create the megaphone
public delegate void DataBackEventHandler(object sender, ApplicationTypes appType);
public event DataBackEventHandler DataBack;
```

## Step 2: Fire the Event (Inside the Child Form)
Go to your `btnSave_Click` method. After you successfully call `.Save()` on the database, use your megaphone to shout the object back out:

```csharp
if (_appType.Save())
{
    // 2. Shout the updated object through the megaphone!
    DataBack?.Invoke(this, _appType);
    
    KryptonMessageBox.Show("Saved Successfully!");
}
```

## Step 3: Listen to the Event (Inside the Main Form)
Now go back to your main grid form (e.g., `frmApplicationTypes.cs`). Inside your Edit click event, you must tell this form to "listen" to the megaphone before you open the child form:

```csharp
private void EditApplicationType(object sender, EventArgs e)
{
    // Get the ID of the selected row
    int selectedID = Convert.ToInt32(dgvApplications.CurrentRow.Cells["ApplicationTypeID"].Value);

    using (frmEditApplication frm = new frmEditApplication(selectedID))
    {
        // 3. Listen to the event!
        frm.DataBack += frmEditApplication_DataBack; 
        
        frm.ShowDialog();
    }
}
```

## Step 4: Update the Grid (Inside the Main Form)
Finally, write the method that actually catches the object and updates the DataGridView row instantly!

```csharp
// 4. Catch the data here!
private void frmEditApplication_DataBack(object sender, ApplicationTypes appType)
{
    // Use .Select() to quickly find the row without needing a Primary Key
    DataRow[] rows = _ApplicationTypesTable.Select($"ApplicationTypeID = {appType.ApplicationTypeID}");
    DataRow rowToEdit = rows.Length > 0 ? rows[0] : null;

    if (rowToEdit != null)
    {
        // Update the visual row instantly!
        rowToEdit["ApplicationTypeTitle"] = appType.ApplicationTypeTitle;
        rowToEdit["ApplicationFees"] = appType.ApplicationFees;
    }
}
```
