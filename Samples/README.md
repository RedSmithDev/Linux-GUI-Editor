
### Samples

when you open Linux forms editor you can copy the sample path in the "Open Project Window"  to a "Existent Project Dir"

And edit the GUI interfaces from that project using the LCSF_Editor .

### Control references in Code

Using by example KitchenTimer Sample code

in Images/03-NamesReferencedByCode-cmb.png and Images/04-NamesReferencedByCode-btn.png

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

