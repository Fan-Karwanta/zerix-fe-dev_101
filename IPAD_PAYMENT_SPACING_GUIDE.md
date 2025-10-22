# iPad Payment Page Spacing Adjustment Guide

## How to Adjust the Header Margin-Top

The margin-top spacing for the "Payment Providers" header on iPad can be easily adjusted by changing a CSS variable.

### Location
File: `Pages\Scheduler\_Styles.cshtml`

### Variable to Change
Look for the `.payment-method-view-v2` class (around line 5167) and find this variable:

```css
.payment-method-view-v2 {
    max-width: 1400px;
    margin: 0 auto;
    /* Adjustable spacing variable for iPad header margin-top */
    --ipad-header-margin-top: 1rem;  /* <-- CHANGE THIS VALUE */
}
```

### How to Adjust

**Current value:** `1rem` (approximately 16px)

**To reduce spacing (bring header closer to top):**
- Try: `0.5rem` (8px)
- Or: `0.75rem` (12px)
- Or: `0rem` (no margin)

**To increase spacing (move header further down):**
- Try: `1.5rem` (24px)
- Or: `2rem` (32px)

### Example Changes

```css
/* Less spacing (closer to top) */
--ipad-header-margin-top: 0.5rem;

/* More spacing (further from top) */
--ipad-header-margin-top: 2rem;

/* No spacing */
--ipad-header-margin-top: 0;
```

## What Was Fixed

1. ✅ **Reduced margin-top** - The "Payment Providers" header now has less space from the top on iPad
2. ✅ **Thinner separator lines** - The horizontal lines between payment providers are now 1px thick (consistent with other screen sizes)
3. ✅ **Removed container top padding** - The `pt-md-5` padding (3rem) is now overridden to `0.75rem` on iPad/tablets **ONLY when the Payment Method page is visible** (line 5381 in _Styles.cshtml)
   - This fix uses CSS `:has()` selector to target only the payment page
   - Other scheduler pages (Service Category, Date/Time, etc.) are NOT affected

## Testing

After making changes:
1. Save the file
2. Refresh the page on your iPad
3. Navigate to the Payment Providers page
4. Check if the spacing looks correct
5. Adjust the variable value if needed

---

**Note:** The variable only affects iPad/tablet view (768px - 1024px). Mobile and desktop views use different styling.
