// Given an array of integers, find the one that appears an odd number of times.
// There will always be only one integer that appears an odd number of times.

function AppearedAtOddNumTimes(input) {
    let uniqueNumber = input.filter((item, i, ar) => ar.indexOf(item) === i);

    for (var i = 0; i < uniqueNumber.length; i++) {
        var totalAppearance = timesAppeared(input, uniqueNumber[i]);

        if (isOdd(totalAppearance)) {
            console.log(uniqueNumber[i] + " occurred " + totalAppearance + " time/s");
        }
    }
}

function timesAppeared(arr, input) {
    return arr.filter((val) => val == input).length;
};

function isOdd(numInput) {
    if (numInput % 2 != 0)
        return true;

    return false;
}

AppearedAtOddNumTimes([7]);
AppearedAtOddNumTimes([0]);
AppearedAtOddNumTimes([1, 1, 2]);
AppearedAtOddNumTimes([0, 1, 0, 1, 0]);
AppearedAtOddNumTimes([1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1]);