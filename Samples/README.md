
### Samples

**To edit GUI interfaces from an existing project using the LCSF_Editor, follow these steps:**

2. **Launch the Linux forms editor.**
4. **In the 'Open Project Window', locate the 'Existent Project Dir' field.**
6. **Copy the path to the directory containing your project files.**
8. **Paste the copied path into the 'Existent Project Dir' field.**
10. **Click the 'Open Project' button to load the project.**
12. **Once the project is open, you can use the LCSF_Editor's tools and features to edit the GUI interfaces as needed.**

### Control references in Code

Using by example KitchenTimer Sample code

```C#
private void Controls_Click(Control sender, efrmMainControls ctlName, EventArgs e)
        {

            switch (ctlName)
            {
                case efrmMainControls.btnStart:
                    tht0.timer.Enabled = true;
                    counter.reset();
                    break;
```

Images/03-NamesReferencedByCode-cmb.png
Images/04-NamesReferencedByCode-btn.png

can explain the relation between the editor en the code.
